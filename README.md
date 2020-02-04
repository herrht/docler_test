# QA Docler Homework

QA case study

## Introduction

This project was created in Visual Studio 2019, using SpecFlow extension for Gherkin features, and C# for code implementation, using Page Object Design pattern.
The goal was to create automated test cases to cover requirements regarding the http://uitest.duodecadits.com webpage.

### Setting up the environment
* [Download Visual Studio Community 2019](https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=Community&rel=16)
* Install VS
  * Select *.NET desktop development*
* Start VS
* Select *Continue without code ->*
* Install extensions: *Extensions / Extension Manager*
  * GitHub Extension for Visual Studio
  * SpecFlow for Visual Studio
* Close VS
  * VSIX installer starts, install the above mentioned two extensions
* Start VS

### Getting the code
* Clone or Check out code from VS, or just use any Git application:
```
git clone https://github.com/herrht/docler_test.git
```

### Running the tests
* File / Open Solution / [your location] / docler_test.sln
* Build / Build Solution
* Test / Test Explorer
* Run All Tests

**Note**
In some cases, it might still does not find any tests on the first run.
Just try to Build again (or worst case close Visual Studio, Start again, Open Solution, Build), and check again the Test Explorer.

### Author
[**Tamas Horvath**](https://www.linkedin.com/in/horvath-tamas-cv/)