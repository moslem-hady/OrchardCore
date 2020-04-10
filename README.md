# Orchard Core 
<!-- ALL-CONTRIBUTORS-BADGE:START - Do not remove or modify this section -->
[![All Contributors](https://img.shields.io/badge/all_contributors-1-orange.svg?style=flat-square)](#contributors-)
<!-- ALL-CONTRIBUTORS-BADGE:END -->

Orchard Core consists of two distinct projects:

- __Orchard Core Framework__: An application framework for building modular, multi-tenant applications on ASP.NET Core.
- __Orchard Core CMS__: A Web Content Management System (CMS) built on top of the Orchard Core Framework.

[![Join the chat at https://gitter.im/OrchardCMS/OrchardCore](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/OrchardCMS/OrchardCore?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
[![BSD-3-Clause License](https://img.shields.io/badge/license-BSD--3--Clause-blue.svg)](LICENSE.txt)
[![Documentation](https://readthedocs.org/projects/orchardcore/badge/)](https://docs.orchardcore.net/)
[![Crowdin](https://d322cqt584bo4o.cloudfront.net/orchard-core/localized.svg)](https://crowdin.com/project/orchard-core)


## Build Status

Stable (master): 

[![Build Status](https://api.travis-ci.org/OrchardCMS/OrchardCore.svg?branch=master)](https://travis-ci.org/OrchardCMS/OrchardCore/branches)
[![Build status](https://img.shields.io/appveyor/ci/alexbocharov/orchardcore/master.svg?label=appveyor&style=flat-square)](https://ci.appveyor.com/project/alexbocharov/orchardcore/branch/master)
[![NuGet](https://img.shields.io/nuget/v/OrchardCore.Application.Cms.Targets.svg)](https://www.nuget.org/packages/OrchardCore.Application.Cms.Targets)

Nightly (dev): 

[![Build Status](https://api.travis-ci.org/OrchardCMS/OrchardCore.svg?branch=dev)](https://travis-ci.org/OrchardCMS/OrchardCore/branches)
[![Build status](https://img.shields.io/appveyor/ci/alexbocharov/orchardcore/dev.svg?label=appveyor&style=flat-square)](https://ci.appveyor.com/project/alexbocharov/orchardcore/branch/dev)
[![MyGet](https://img.shields.io/myget/orchardcore-preview/vpre/OrchardCore.Application.Cms.Targets.svg)](https://myget.org/feed/orchardcore-preview/package/nuget/OrchardCore.Application.Cms.Targets)

## Status

### RC 1

The software is almost ready for final release. No feature development or enhancement of the software is undertaken; tightly scoped bug fixes are the only code you're allowed to write in this phase, and even then only for the most heinous and debilitating of bugs.

Here is a more detailed [roadmap](https://github.com/OrchardCMS/OrchardCore/wiki/Roadmap).

## Getting Started

- Clone the repository using the command `git clone https://github.com/OrchardCMS/OrchardCore.git` and checkout the `dev` branch.

### Command line

- Install the latest version of the .NET Core SDK from this page <https://www.microsoft.com/net/download/core>
- Next, navigate to `D:\OrchardCore\src\OrchardCore.Cms.Web` or wherever your folder is on the commandline in Administrator mode.
- Call `dotnet run`.
- Then open the `http://localhost:5000` URL in your browser.

### Visual Studio

- Download Visual Studio 2019 (any edition) from https://www.visualstudio.com/downloads/
- Open `OrchardCore.sln` and wait for Visual Studio to restore all Nuget packages
- Ensure `OrchardCore.Cms.Web` is the startup project and run it

### Docker

- Run `docker run --name orchardcms orchardproject/orchardcore-cms-linux:latest`

Docker images and parameters can be found at <https://hub.docker.com/u/orchardproject/>

### Documentation

The documentation can be accessed here: <https://docs.orchardcore.net/>

## Contributors ✨

Thanks goes to these wonderful people ([emoji key](https://allcontributors.org/docs/en/emoji-key)):

<!-- ALL-CONTRIBUTORS-LIST:START - Do not remove or modify this section -->
<!-- prettier-ignore-start -->
<!-- markdownlint-disable -->
<table>
  <tr>
    <td align="center"><a href="http://antoinegriffard.com"><img src="https://avatars3.githubusercontent.com/u/703248?v=4" width="100px;" alt=""/><br /><sub><b>Antoine Griffard</b></sub></a><br /><a href="https://github.com/OrchardCMS/OrchardCore/commits?author=agriffard" title="Tests">⚠️</a> <a href="https://github.com/OrchardCMS/OrchardCore/commits?author=agriffard" title="Documentation">📖</a></td>
  </tr>
</table>

<!-- markdownlint-enable -->
<!-- prettier-ignore-end -->
<!-- ALL-CONTRIBUTORS-LIST:END -->

This project follows the [all-contributors](https://github.com/all-contributors/all-contributors) specification. Contributions of any kind welcome!