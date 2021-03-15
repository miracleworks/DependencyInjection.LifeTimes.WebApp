Tutorial: https://medium.com/net-core-dependency-injection/asp-net-core-dependency-injection-3aa993c2b583
Repo: https://github.com/aloatias/DependencyInjection.LifeTimes.WebApp

My Fork: https://github.com/miracleworks/DependencyInjection.LifeTimes.WebApp


Notes:
Singleton -- Same across multiple web requests. Same across multiple client object requests.
Transient -- Always Different 
Scoped -- Different across multiple web requests. Same across multiple client object requests. 

Following warning were captured using two seperate requests. It shows above concept.

-- Request 1
DI.LifeTimes.WebApp.Controllers.HomeController: Warning: Singleton: e1d9aeae-8386-4768-ac3f-7a1c13c4560d 
DI.LifeTimes.WebApp.Controllers.HomeController: Warning: Transient: 18d440f2-4adf-4139-ab09-a6e1ee455db1
DI.LifeTimes.WebApp.Controllers.HomeController: Warning: Scoped: 12f09aec-a968-4443-ba8c-bb0ef877e527

DI.LifeTimes.WebApp.Controllers.HomeController: Warning: MyService Singleton: e1d9aeae-8386-4768-ac3f-7a1c13c4560d
DI.LifeTimes.WebApp.Controllers.HomeController: Warning: MyService Transient: 8c557663-7c86-4c74-9311-5ab02ce383b3
DI.LifeTimes.WebApp.Controllers.HomeController: Warning: MyService Scoped: 12f09aec-a968-4443-ba8c-bb0ef877e527

-- Request 2
DI.LifeTimes.WebApp.Controllers.HomeController: Warning: Singleton: e1d9aeae-8386-4768-ac3f-7a1c13c4560d
DI.LifeTimes.WebApp.Controllers.HomeController: Warning: Transient: 5f91725f-67d6-4f77-8a92-3db1b445d22b
DI.LifeTimes.WebApp.Controllers.HomeController: Warning: Scoped: 6ea8c7bf-5ae4-45b1-b52b-c5db2d8b6674

DI.LifeTimes.WebApp.Controllers.HomeController: Warning: MyService Singleton: e1d9aeae-8386-4768-ac3f-7a1c13c4560d
DI.LifeTimes.WebApp.Controllers.HomeController: Warning: MyService Transient: a6a4611b-64f5-4bf6-8fb5-a929cef22574
DI.LifeTimes.WebApp.Controllers.HomeController: Warning: MyService Scoped: 6ea8c7bf-5ae4-45b1-b52b-c5db2d8b6674