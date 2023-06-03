# NetServices
Advanced example of Microservices in .NET 5 and using SQL database, Kubernetes, gRPC, Docker

## Docker

```dockerfile
docker build -t amg31/platformservice .
docker run -p 8080:80 -d amg31/platformservice
docker run -p 443:80 -d amg31/platformservice (to match our docker build specs)
docker push amg31/platformservice
```




