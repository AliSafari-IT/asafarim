---
sidebar_position: 1
---

# What, Why and How of Nx
## What is Nx?
🔎 Nx is a set of Extensible Dev Tools for Monorepos. There you can make use of monorepo approach development by forming various applications inside a workspace and employ re-usable libs through React, Angular, and Node applications. Nx supports many plugins which add resources for developing different types of applications and tools. Such capabilities include generating applications, libraries, components, and so on as well as development tools to test or build projects.

## Why Nx?
With nx Extensible Build Framework, one can build full-stack applications with modern tools while creating a workspace for the entire development team. Nx provides better linting, better testing, faster CLI, and support for popular community libraries and tools. Nx uses distributed graph-based task execution and computation caching. One of the good things of the Nx tool is that by adding another app to the repo Nx ensures that the existing app's test and or build time does not increase.

## How to set up an Nx workspace?
By running the command below in a terminal you can make a new nx workspace:

```bash title="Create new Nx workspace (version: 12.5.0)"
npx create-nx-workspace@latest
```
Answer the questions like:
- *<span style={{ padding: '3px', backgroundColor: 'tomato' }}>workspace name</span>*: type a name for your workspace,
- *<span style={{ padding: '3px', backgroundColor: 'tomato' }}>What to create in the new workspace ...</span>*: choose the type of application you want to create.,

- *<span style={{ padding: '3px', backgroundColor: 'tomato' }}>Add a stylesheet</span>*: choose whether you want to add a stylesheet or not.


