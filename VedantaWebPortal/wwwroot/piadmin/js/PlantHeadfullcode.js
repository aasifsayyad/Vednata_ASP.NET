$(document).ready(function () {
	var t = $('#example23').DataTable();          
	$.each(plantHead, function (key) {
			var rankingElements = [];
			var batch = {
				"database": {
					"Method": "GET",
					"Resource": baseServiceUrl + "elements?path=\\\\" + afServerName + "\\" + afDatabaseName + "\\KPIS\\PlantHead\\" + plantHead[key].afname + "&selectedFields=WebId;Links.Elements"
				},
				"elements": {
					"Method": "GET",
					"Resource": "{0}?selectedFields=Items.Name;Items.Path;&searchFullHierarchy=true",
					"ParentIds": ["database"],
					"Parameters": ["$.database.Content.Links.Elements"]
				},
				"attributes": {
					"Method": "GET",
					"RequestTemplate": {
						"Resource": baseServiceUrl + "attributes/multiple?selectedFields=Items.Object.Name;Items.Object.Path;Items.Object.WebId&" + plantHead[key].path
					},
					"ParentIds": ["elements"],
					"Parameters": ["$.elements.Content.Items[*].Path"]
				},
				"values": {
					"Method": "GET",
					"RequestTemplate": {
						"Resource": baseServiceUrl + "streams/{0}/value"
					},
					"ParentIds": ["attributes"],
					"Parameters": ["$.attributes.Content.Items[*].Content.Items[*].Object.WebId"]
				}
			};
			var batchStr = JSON.stringify(batch, null, 2);
			var batchResult = processJsonContent(baseServiceUrl + "batch", 'POST', batchStr);
			$.when(batchResult).fail(function () {
				warningmsg("Cannot Launch Batch!!!");
			});
			$.when(batchResult).done(function () {
				var batchResultItems = (batchResult.responseJSON.attributes.Content.Items);
				let valuesID = 0;
                                                     var UOM="-";
                                                     var UO = (batchResult.responseJSON.values.Content.Items[valuesID].Content.UnitsAbbreviation);
                                                      if(UO){ UOM=UO; }
				$.each(batchResultItems, function (elementID) {
					var attrItems = batchResultItems[elementID].Content.Items;
					var elementName = batchResult.responseJSON.elements.Content.Items[elementID].Name;
					var elementItems = [];
					attrItems.forEach(function (attr, attrID) {
						let attrValue = "-";
						if (attr !== undefined && attr.Object !== undefined) {
							attrName = attr.Object.Name;
							const getNestedObject = (nestedObj, pathArr) => {
								return pathArr.reduce((obj, key) => (obj && obj[key] !== undefined) ? obj[key] : undefined, nestedObj)
							}
							if (batchResult.responseJSON.values.Content.Items !== undefined && (batchResult.responseJSON.values.Content.Status === undefined || batchResult.responseJSON.values.Content.Status < 400) && batchResult.responseJSON.values.Content.Items[valuesID].Status === 200) {
								var attrV = getNestedObject(batchResult.responseJSON.values, ['Content', 'Items', valuesID, 'Content', 'Value']);
                                                                                                          // var U = getNestedObject(batchResult.responseJSON.values, ['Content', 'Items', valuesID, 'Content', 'UnitsAbbreviation']);  
                                                                                                          
								if (attrV !== "" && !isNaN(attrV)) {
									//attrValue = (Math.round((attrV) * 100) / 100);
                                                                                                                        attrValue = (attrV).toFixed(plantHead[key].digits);
								}
							}
						}                                                               
						elementItems[attrID] = attrValue;
						valuesID++;
					});
					rankingElements[elementID] = elementItems;
				});
				var rows = [];
                                                     rows.push(plantHead[key].sr);
				rows.push(plantHead[key].afname);
                                                     rows.push(UOM);
				$.each(rankingElements, function (key1) {
					rows.push(rankingElements[key1][1], rankingElements[key1][0]);
				});
				t.row.add(rows).draw(!1);
			});
                                t.page.len( -1 ).draw();		
	});
});