This is web api project. Web api was developed as multilayer structure

Controller folder 
is for service layer, which we define web apis , calls the business layer

Manager folder 
is for business layer, which we put business logic and calss the data layet

Data folder 
is for data layer, which we get data from data source. In this example we dont have database, we hardcoded datas in 
PersonRepository.cs. We could have taken datas from database either accesing database by SPs  directly or 
ORM (Object–relational mapping) frameworks such as EntityFramework

Model Folder 
is for data models which are used through controller, business, and data layers.


*Web apis : GetPersonList, GetPersonListByName, CreatePerson   can be found in PersonController.cs 
You can ignore WeatherForecastController.cs which was  created automatically when initial web api project was created.
WeatherForecastController is inherited from ControllerBase , you can try this web api with swagger as well.

*Dependency injections are registered at program.cs 
builder.Services.AddSingleton<IPersonManager, PersonManager>();
builder.Services.AddSingleton<IPersonRepository, PersonRepository>();








