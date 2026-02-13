# JSONist
Simple analysis tool for Network Rail Tiplocs ([Start Here](https://railmap.azurewebsites.net/Downloads))

Supports a number of features, including LINQ querying at runtime. The entire LINQ library is usable and an example statement is provided below:

```
Tiplocs.Where(t => t.Details.CRS != null && t.Details.CRS.StartsWith("M"))
```
