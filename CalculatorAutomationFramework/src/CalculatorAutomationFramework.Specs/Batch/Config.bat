@echo off

COLOR 0a

:: PROJECT FILES
SET ProjectHome= C:\Software\Jenkins\workspace\WhiteSikuliFramework\WhiteSikuliFramework
SET LivingDocFolder=%ProjectHome%\src\WhiteSikuliFramework.Specs\bin\Debug\LivingDoc
SET FeatureFolder=%ProjectHome%\src\WhiteSikuliFramework.Specs\Features
SET SpecsDLL=\src\WhiteSikuliFramework.Specs\bin\Debug\WhiteSikuliFramework.Specs.dll
SET BDDTestProject="%ProjectHome%\src\WhiteSikuliFramework.Specs\WhiteSikuliFramework.Specs.csproj"


:: UTILITIES
SET PicklesExe=%ProjectHome%\packages\Pickles.CommandLine.2.15.0\tools\pickles.exe
SET MSTestExe="%ProgramFiles(x86)%\Microsoft Visual Studio\2017\Community\Common7\IDE\MSTest.exe"
SET SpecflowExecutable=%ProjectHome%\packages\SpecFlow.2.1.0\tools\specflow.exe

::C:\Users\TechTeam\Desktop\UnifaceAutomationFramework\packages\Pickles.CommandLine.2.15.0\tools\pickles.exe


:: FILE NAMES
SET StepDefHTMLOutput=StepDefinitionReport.html
SET MsTestResultFile="TestResults.trx"
SET HTMLTestOutput="TestResults.html"

