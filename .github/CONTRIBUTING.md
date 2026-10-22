# Contributing

This repository holds the Ignite UI for Blazor samples: the standalone sample apps under `samples/`, which the documentation embeds, and the samples browser under `browser/`, which lists them all. To contribute:

1. Create a branch, or fork the repository (see [Branches](#branches) for where to branch from).
2. Make the change and build every sample you add or change (`dotnet build` on its `BlazorClientApp.csproj`; `dotnet run` serves it at http://localhost:4200). No checks run on pull requests in this repository, so the local build is the check.
3. Open a pull request that references the issue you're working on.

The pull request is reviewed and tested before it's merged.

# Workflow

When working on an issue or a pull request, keep its labels current, so everyone can see where it stands.

## Issues

- `bug: in-sample`, `bug: in-browser`, `bug: in-product` or `bug: in-docs` says where the problem is: a sample, the samples browser, the Ignite UI product, or the documentation.
- `severity: low`, `severity: high` or `severity: critical` says how much it matters.
- `status: investigate` asks to check whether the issue still occurs in the sample or the product.
- `status: cant-reproduce` and `status: wontfix` close an issue that won't be fixed.
- `status: resolved` marks an issue that a pull request resolves, open or merged.

## Development - pull requests

1. `status: in-development` while the pull request is still being worked on.
2. `status: in-review` once it's ready for a review, and `status: peer resolved` once a review has been addressed.
3. `status: blocked` when it waits on a product or API change, and `status: do-not-merge` when it isn't ready or is risky to merge.

Samples authored in [igniteui-xplat-examples](https://github.com/IgniteUI/igniteui-xplat-examples) arrive in pull requests labeled `area: auto-generated-xplat`. `status: cant change xplat sample` marks a pull request that should make its change in that repository instead, and `status: waiting for xplat PR` one that depends on a pull request there.

## Testing - pull requests

1. `awaiting-test` once development is done and the pull request is ready for verification.
2. `status: in-test` while someone tests it.
3. `status: verified` once it's tested and ready for merging.

`awaiting-test` => `status: in-test` => `status: verified` (the pull request can be merged)

When testing a pull request, build and run the samples it changes, and check that they work in the samples browser as well.

# Branches

`vnext` holds the samples for the next release, and `master` the samples for the current one; the samples browser deploys from both. `vnext` is merged into `master` with regular pull requests, so a change normally goes to `vnext` only.

Cherry-pick a change to `master` as well only when it's a fix of high or critical severity that the current release needs:

1. Create a branch from `vnext`, e.g. `fixing-bug-1234-vnext`, commit the fix there, and open a pull request against `vnext`.
2. Create a branch from `master`, e.g. `fixing-bug-1234-master`, and cherry-pick the fix onto it: `git cherry-pick <commit>`.
3. Push it and open a pull request against `master`.

# Commit messages

Use the conventional format `<type>(<scope>): <subject>`, with the component or area as the scope, e.g. `feat(chip): add outlined sample` or `fix(browser): remove sample container padding`. Use `*` when a change spans several areas.
