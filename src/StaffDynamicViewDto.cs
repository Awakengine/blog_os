/// <summary>
/// 用户类别
/// </summary>
[Column("staff_category")]
[JsonProperty("staff_category")]
[Description("用户类别")]
public string Id{get;set;}


/*
* nuget 更新命令
* dotnet push delete Testcc.cc.ccc.1.0.6 1.0.6.nupkg  -s http://127.0.0.1:8888/v3/index.json -k xxxxxxxxxx
*
* nuget 删除命令
* dotnet nuget delete Testcc.cc.ccc.1.0.6 1.0.6  -s http://127.0.0.1:8888/v3/index.json -k xxxxxxxxxx
*/