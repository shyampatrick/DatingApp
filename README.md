# ASP.Net Core SPA Web API + Angular Demo

## Dating App

This is a demo app featuring a Full Stack Web API + Angular framework. It is pretty advanced and is derived from Coursework on Udemy. I really think it is a suitable demonstration of Web Developer skills and qualifications as I finished the course apart from the bonus + 3.0 update - which I'm going to be doing shortly.

It is simple, has enough demonstrative qualities and is a good benchmark for describing intermediate skills in the above technologies.

Dockerfiles included. Please don't hesitate to get in touch:

shyampatrick@outlook.my (gitHub) || shyamkumarpatrick@gmail.com (professional) || sykron@gmail.com (old)

_Currently, I have some complications with docker so please ignore the various dockerfiles in the repo - will be building app and placing it in DatingApp.Dist directory from which the prebuilt dockerfile can run without complications._

Run:

dotnet publish -c Release ./DatingApp.API -o ../DatingApp.Dist
docker-compose up --build

_This has a prebuilt step involved to get the App running in the container environment with a MySQL server_

### _But I feel the best solution is to just run with the dev sqlite without the publish step - until I fix it - seems to be mostly to do with Docker networking and hosts_

dotnet run
&&
ng serve

_This works 100%_
