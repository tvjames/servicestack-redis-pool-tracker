servicestack-redis-pool-tracker
===============================

Simple resource tracker to keep track of instances of ```IRedisClient``` handed out
by ```IRedisClientsManager```. 

This is a rather naive implementation and is not expected to be performant. It
should not be run in production or performance sensitive environments. It should be 
used as a diagnostic tool. 

It will dump to the log a count of redis client instances held by type of instance 
holding the redis client. 

YMMV.

> Note: This library is written against vserion 3 of the ServiceStack libraries.  

Usage
-----

```csharp

var pool = new PooledRedisClientManager(...);
var proxy = new TrackingRedisClientsManager(pool);
container.Register<IRedisClientsManager>(proxy);


```
