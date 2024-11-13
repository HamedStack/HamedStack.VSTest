# HamedStack.VSTest

A C# TRX file parser based on `vstst.xsd` schema. It covers all details you need.

```cs
TestRunType? testRun = TestSchemaManager.ConvertToTestRun(trxContent);
```

This library built based on [XmlSchemaClassGenerator](https://github.com/mganss/XmlSchemaClassGenerator).