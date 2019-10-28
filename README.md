# DockerDemoDotNet
This is a sample project that uses docker on windows containers to run a .net framework web api application on a single container

#Steps to Build Image and run container in Powershell
1) $docker build -t YourUserName/dockertrial -f ./Dockerfile.txt .
2) $docker images
3) $docker run -d -p 7991:80 --name docker-trial-api YourUserName/dockertrial
4) $docker ps -a

#To publish image online on docker hub
$docker push YourUserName/dockertrial
