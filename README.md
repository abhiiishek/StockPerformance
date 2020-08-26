# StockPerformance 
I have completed this solution using
1) .net core 3.1 (framework)
2)WEB API
3) Jquery Ajax (to call the web api)
4) d3.js api for chart
5) Visual Studio 2019
6) GitHub repo for version and source control

Note: I have made static file (StockPerformance.html) as starup page which is in wwwroot instead of .aspx or .chtml , by registering the service in StartUp.cs
            DefaultFilesOptions options = new DefaultFilesOptions();
            options.DefaultFileNames.Clear();
            options.DefaultFileNames.Add("StockPerformance.html");
            app.UseDefaultFiles(options);
            app.UseStaticFiles();


finally I have pushed all my changes to GitHub
