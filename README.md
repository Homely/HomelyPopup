<div>
    <p align="center">
    <img src="https://imgur.com/9E8hN79.png" alt="Homely" />
    </p>
</div>

This is a set of templates to be used by hiring candidates for the HomelyPopup excercise.

You can choose from one of the following project templates:
- ASP.NET Core 2 API
- ASP.NET MVC / Web API

There is no code in any of the templates other than what File > New in Visual Studio brings.

However, seperate projects have been added to each sln, to give the candidate a 'hint' to the type of code, patterns and seperation we like to see.

If you prefer, you can use your own project template instead.

Here is the connection string to the database (SQL Server instance in Azure):

```
Server=tcp:homelypopupstore.database.windows.net,1433;Initial Catalog=HomelyPopupStore;Persist Security Info=False;User ID=readonlylogin;Password=homely!readonly!2018;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;
```

(note: there is a firewall on the DB, so only whitelisted IP's will gain access..which we can arrange at the time of the interview)

Good luck! :)
