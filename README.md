# VisualStudioUnitTestExample

Example of MSTest for a WindowsForm project


## Adding Tests to an Existing Windows Forms Project

* Create New Project -> `C#`, `Windows`, `Desktop` -> Windows Forms App -> .NET 5.0
* Solution `WinFormsApp1` (1 of 1 project) -> Right CLick -> Add -> New Project -> "NUnit Test Project" or "MSTest Test Project" -> .Net 5.0
* `WinFormsApp1` -> Right Click -> Add -> Class
* Add to `Class1.cs`
* ```csharp
    public class Class1
    {
        private int _value;
        public int value {get { return _value; }}

        public Class1(int a) {
            this._value = a + 1;
        }

    }
	```
	* note the addition of `public` to the class definition
* TestProject1 -> Dependencies -> Right Click -> Add Project Reference -> `WinFormsApp1`
* `TestProject1.csproj` -> manualy update `<TargetFramework>net5.0</TargetFramework>` to `<TargetFramework>net5.0-windows</TargetFramework>`
* Add to `UnitTest1.cs`
* ```csharp
    using WinFormsApp3;

        // ...

        [Test]  // MSTest uses `[TestMethod]`
        public void TestClass1()
        {
            var tt = new Class1(10);
            Assert.AreEqual(tt.value, 11);
        }
	```
* `Test` Menu at top -> Run All Test (or `Ctrl+r a`)


Notes
-----

* The above example add's a Test package to an existing Form program.
	* This means the entire thing can only be tested on a windows system
	* We would want CI (e.g. GitHub on commit to run these tests)
* TODO: Make a demo of this stucture so the tests can run on CI (GitHub commit)
	* Form (.netX.x-windows)
		* Just view code
	* Core (.netX.x)
		* All the actual program logic
	* Test (.netX.x)
		* Testing `Core` (no need to engage with `Form`)



References
----------

1. https://docs.microsoft.com/en-us/visualstudio/test/getting-started-with-unit-testing
	* Add separate Test project
	* Add this new project as a depenency
2. Manually put the targets to be inline `.net5-windows`
	* https://stackoverflow.com/questions/46833402/what-do-yellow-warning-triangles-mean-on-dependencies-in-visual-studio-2017
3. Build + Add import

