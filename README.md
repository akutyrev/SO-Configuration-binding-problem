# SO-Configuration-binding-problem
This is a demo of Configuration binding problem in .net core web service.

This problem is mentioned in this [Stackoverflow question](https://stackoverflow.com/questions/41369996/how-do-i-bind-a-multi-level-configuration-object-using-iconfiguration-in-a-net)

To use this demo just launch it and open http://localhost:<your-port>/api/settings?withJsonProperties=true and then the same with false value. 

If binding settings file to object was working properly with JsonProperty attributes then the results should be the same, but they are not
