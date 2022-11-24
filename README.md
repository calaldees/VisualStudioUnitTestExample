# VisualStudioUnitTestExample

Example of MSTest for a WindowsForm project


## Adding Tests to a 'Windows Forms App' Project

* (if starting from scratch) Create New Project -> `C#`, `Windows`, `Desktop` -> Windows Forms App -> .NET X.X
* `Solution WinFormsApp1 (1 of 1 project)` -> Right CLick -> Add -> New Project -> "NUnit Test Project" or "MSTest Test Project" -> .Net X.X
    * This will add a `TestProject1`
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
* `TestProject1` -> Dependencies -> Right Click -> Add Project Reference -> `WinFormsApp1`
* `.csproj` files should use the same `<TargetFramework>` (this is not done by default)
    * In `TestProject1.csproj` -> replace `<TargetFramework>netX.X</TargetFramework>` with `<TargetFramework>netX.X-windows</TargetFramework>`
* Add to `UnitTest1.cs`
* ```csharp
    using WinFormsApp1;

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
	* This means the entire project can _only_ be tested on a windows system
	* In future we would want CI (e.g. GitHub on commit to run these tests)

View-Model-Test - 3 part project
--------------
* TODO: Make a demo of this structure so the tests can run on CI (GitHub commit)
	* `Form` View (.netX.x-windows)
		* The MINIMUM possible view code
	* `Core` Model (.netX.x)
		* All the actual program logic
	* `Test` (.netX.x)
		* Testing `Core` (no need to engage with `Form`)


References
----------

1. https://docs.microsoft.com/en-us/visualstudio/test/getting-started-with-unit-testing
	* Add separate Test project
	* Add this new project as a depenency
2. Manually put the targets to be inline `.net5-windows`
	* https://stackoverflow.com/questions/46833402/what-do-yellow-warning-triangles-mean-on-dependencies-in-visual-studio-2017
3. Build + Add import

