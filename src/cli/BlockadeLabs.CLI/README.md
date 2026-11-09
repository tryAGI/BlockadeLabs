# BlockadeLabs.CLI

Command-line interface for the BlockadeLabs SDK generated with AutoSDK.

## Installation

```bash
dotnet tool install --global BlockadeLabs.CLI --prerelease
```

## Usage

```bash
blockade-labs --help
blockade-labs skybox-exports --help
```

## Shell completion

The `completion` command prints a script built from the live command tree, so
subcommands, option names and the values of enum-typed options stay correct after the
spec is refreshed and the CLI regenerated — there is no word list to maintain.

```bash
blockade-labs completion bash > /usr/local/etc/bash_completion.d/blockade-labs
blockade-labs completion zsh  > _blockade-labs   # then put it on your zsh fpath
blockade-labs completion fish > ~/.config/fish/completions/blockade-labs.fish
```

## Customization

Generated operation, tag, and API group command classes are partial. Implement
`static partial void CustomizeCommand(ref Command command)` in a separate source
file to add aliases or validators, change the action, or replace a command. The
hook runs after the generated command has been configured.