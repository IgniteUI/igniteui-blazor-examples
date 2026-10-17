# Contributing

1. Branch from `vnext` (or fork the repository) and open the pull request against `vnext`.
2. Build every sample you add or change (`dotnet build` on its `BlazorClientApp.csproj`; `dotnet run` serves it at http://localhost:4200). No pull request checks run in this repository, so the local build is the check.

## Branches

`vnext` holds the samples for the next release and `master` the current one; the samples browser deploys from both. `master` gets `vnext` through regular merge pull requests, so a change normally goes to `vnext` only. A fix of high or critical severity that the current release needs too also goes to `master`: cherry-pick its commit onto a branch from `master` and open a second pull request against `master`.

## Commit messages

Use the conventional format `<type>(<scope>): <subject>`, with the component or area as the scope, e.g. `feat(chip): add outlined sample` or `fix(browser): remove sample container padding`. Use `*` when a change spans several areas.
