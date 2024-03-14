# Installation
Um die App auszuführen, benötigen Sie:
1. Visual Studio mit Unterstützung für ASP.NET-Entwicklung
2. Google Chrome Browser (für die Selenium-Tests)
# Ausführung
1. Öffnen Sie die Solution-Datei WebApp.sln in Visual Studio.
2. Legen Sie das Projekt WebApp als Startprojekt fest.
3. Starten Sie die Webanwendung in Visual Studio, indem Sie auf die Schaltfläche "http" klicken. 
# Unit-Tests mit Selenium
1. Die Unittests erfordern eine laufende Instanz der Webanwendung.
2. Öffnen Sie die Solution-Datei UnitTest.sln in Visual Studio.
3. Öffnen Sie das Test-Explorer-Fenster in Visual Studio.
4. Führen Sie die Unittests aus, indem Sie auf "Alle Tests ausführen" klicken.
5. Wenn die Selenium-Tests nicht funktionieren, überprüfen Sie die URL in der Datei WebTest.cs und passen Sie sie an, falls erforderlich.
