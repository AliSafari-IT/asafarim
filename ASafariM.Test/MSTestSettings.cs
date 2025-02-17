using Microsoft.VisualStudio.TestTools.UnitTesting;

[assembly: Parallelize(Scope = ExecutionScope.MethodLevel)]
[assembly: DoNotParallelize] // This can help reduce the number of deployment directories
