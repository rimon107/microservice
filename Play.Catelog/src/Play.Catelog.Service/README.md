Catelog Microservice
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

command:

::

$ dotnet new webapi -n Play.Catelog.Service --framework net5.0
$ dotnet dev-certs https --trust
$ dotnet add package MongoDB.Driver
$ docker run -d --rm --name mongo -p 27017:27017 -v mongodbdata:/data/db mongo
