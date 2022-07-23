# Fable.Builders.ReactRouterDom

## Getting Started

```bash
yarn add react-router-dom
dotnet package add Fable.Builders.ReactRouterDom
```


## Usage

```fsharp
    [<StringEnum>] Page = SyntaxPage | ButtonPage

    BrowserRouter {
        Routes {
            Route {
                path "/"
                element (App model dispatch)
                
                Route { path (string Page.SyntaxPage); element (SyntaxPage.view model) }
                Route { path (string Page.ButtonPage); element (ButtonPage.view model) }
            }
        }
    }
```