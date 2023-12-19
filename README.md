Web api was developed in multi-tiered structure

Controller folder is for service layer, which we define web apis , calls the business layer
Manager folder is for business layer, which we put business logic and calss the data layet
Data folder is for data layet, which we get data from data source. In this example we dont have database, we hardcoded datas in PersonRepository.cs. 
We could have taken datas from database either accesing database by SPs  directly or ORM (Object–relational mapping) frameworks such as EntityFramework

*Web apis : GetPersonList, GetPersonListByName, CreatePerson   can be fround on PersonController.cs





