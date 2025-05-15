using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;

// All of these work just fine switching to 2.2.0 on the csproj
_ = typeof(ProducesDefaultResponseTypeAttribute);
_ = typeof(ApiConventionNameMatchAttribute);
_ = typeof(ApiConventionNameMatchBehavior);
_ = typeof(ApiConventionTypeMatchBehavior);
_ = typeof(ApiConventionTypeAttribute);