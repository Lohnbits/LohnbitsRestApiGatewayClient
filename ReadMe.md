## Lohnbits REST API Gateway
Das Lohnbits REST API Gateway kann nur in Verbindung mit Lohnbits eingesetzt werden.  

Das Lohnbits REST API Gateway stellt eine REST Schnittstelle zum Lohnbits Server zur Verfügung, die im Gegensatz zur Haupt-API dokumentiert und leichter zu benutzen ist.  

Bevor das Gateway verwendet werden kann, muss mit den Lohnbits REST API Tools und einem Zugangsbarcode ein Benutzer eingerichtet werden.  

Dieses Repository enthält eine Beispielanwendung in C#.  
  
### Swagger Dokumentation
Die Dokumentation der Schnittstelle ist unter `/swagger` verfügbar.  
Wir empfehlen folgenden Viewer: https://editor-next.swagger.io/.

### Sicherheitshinweis
Das Lohnbits REST API Gateway ist nur zum Einsatz im lokalen Netzwerk geeignet.  
Für einen öffentlichen Zugriff im Internet reicht der Sicherheitsstandard nicht aus. 

### Beispielanwendung
#### Dokument in die Personalakte hochladen
Der Code im Verzeichnis Samples/UploadDocument zeigt, wie ein Dokument in die Personalakte hochgeladen wird.
