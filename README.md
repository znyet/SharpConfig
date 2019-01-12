# SharpConfig
Fork from https://github.com/cemdervis/SharpConfig  <br>
Read and write ini file<br>
Builder net40 and net45 <br>

## Config.ini
```c#
[config]
name=张三
sex=1
```

## Read
```c#
string file = System.AppDomain.CurrentDomain.BaseDirectory + "\\Config.ini";
var config = Configuration.LoadFromFile(file);
var section = config["config"];
string name = section["name"].StringValue;
int sex = section["sex"].IntValue;
```

## Write
```c#
string file = System.AppDomain.CurrentDomain.BaseDirectory + "\\Config2.ini";
var config = new Configuration();
var section = config["config"];
section["name"].SetValue("李四");
config.SaveToFile(file);
```
