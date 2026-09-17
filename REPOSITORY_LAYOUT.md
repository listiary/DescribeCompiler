### Directories<br>

`/.git`<br>
The git folder.<br>

`/.github`<br>
Documents related to GitHub workflows, policies, etc.<br>
<br>

```
/release
/release/0.9.0
...
/release/1.0.1-beta
/release/latest-unstable
```
The release folder.
Contains different releases of the Compiler.<br>
The `latest-unstable` folder contains the last version that might not be released yet, but testers can test.<br>
<br><br>

```
/src
/src/.vs
/src/AntlrRuntime
/src/DescribeParser
/src/DescribeTranspiler
/src/DescribeTranspiler.CLI
/src/DescribeTranspiler.AWS
/src/Tests.Integration.Parser
/src/Tests.Integration.Transpiler
/src/Tests.Unit.Parser
```
The actual source code of the Compiler.<br>
The `.vs` folder is a visual studio special folder.<br>
The `AntlrRuntime` is the ANTLR4 C# runtime - a Visual Studio project.<br>
The `DescribeParser` is the ANTLR4 based parser for Describe, Visual Studio project.<br>
The `DescribeTranspiler` is the DescribeParser based transpiler for Describe, Visual Studio project.<br>
The `DescribeTranspiler.CLI` is the CLI based front end for the DescribeTranspiler, Visual Studio project.<br>
The `DescribeTranspiler.AWS` is the Amazon Web Service - Lambda based front end for the DescribeTranspiler, Visual Studio project.<br>
<br>
The `Tests.Integration.Parser` - Integration tests for the DescribeParser, Visual Studio project.<br>
The `Tests.Integration.Transpiler` - Integration tests for the DescribeTranspiler, Visual Studio project.<br>
The `Tests.Unit.Parser` - Unit tests for the DescribeParser, Visual Studio project.<br>
<br>
We also have the `.gitignore` and `.dockerignore` files here, the `DescribeCompiler.sln` - Visual Studio solution file, and a cleanup batch script - `cleanup.bat` - that strips the visual studio compilation artifacts when executed.
<br><br>
<br>

```
/z_highlighting
/z_highlighting/Notepad++
```
Configuration files and instructions on setting up Describe highlighting in various text editors.
(Currently only for Notepad++ tho).
The `Notepad++` folder contains the configs for Notepad++.
<br><br>
<br>

```
/z_work
/z_work/canvas-tool
```
This folder contains different files that have been worked on in the past and could be useful for future work.
Tools, assets, etc.
The `canvas-tool` is a small utility website, that generates solid color backdrops from URL parameters, directly in your browser, so that you can use it as backdrop for some screenshots. <br>
<br><br>


### Documents<br>

LICENSE.md<br>
README.md<br>
REPOSITORY_LAYOUT.md
