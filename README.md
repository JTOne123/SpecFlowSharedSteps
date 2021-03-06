# SpecFlow Shared Steps <img src="https://raw.githubusercontent.com/Bakanych/SpecFlowSharedSteps/master/SpecFlowSharedSteps/package-icon.png" width="40"/>

[![Build status](https://ci.appveyor.com/api/projects/status/g18m571fd85vtiys?svg=true)](https://ci.appveyor.com/project/Bakanych/specflowsharedsteps) [![NuGet version](https://badge.fury.io/nu/specflow.sharedsteps.svg)](https://badge.fury.io/nu/specflow.sharedsteps)

## Download

The latest version is [available on Nuget](https://www.nuget.org/packages/SpecFlow.SharedSteps/)

## Configuration

Add or update the following section in your `specflow.json`:

```
  "stepAssemblies": [
    { "assembly": "SpecFlowSharedSteps" }
  ]
```

## Usage

Assume you have some set of steps you wanna share between your specflow scenarios.

Now it's as easy as just one step:

```gherkin
Given I execute the steps of 'My Feature'.'Some Scenario'
```

or

```gherkin
Given I execute background steps of Some Feature

# for quote lovers:
Given I execute background steps of 'Some Feature'
```

or even

```gherkin
Given I execute the steps of:
| feature     | scenario       |
| Feature One | Shared Steps 1 |
| Feature Two | Shared Steps 2 |
```

See more [examples](https://github.com/Bakanych/SpecFlowSharedSteps/blob/master/SpecFlowSharedSteps.Tests/Features/MasterFeature.feature)

### Shared context

Parent Feature and Scenario Context is used by shared steps. Context values created by shared steps are available in parent scenario.
Be careful with context key duplication.


