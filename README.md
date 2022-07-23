# Fable.Builders.Emotion

## Getting Started

```bash
yarn add @emotion/css
dotnet package add Fable.Builders.Emotion
```


## Usage

```fsharp
    div {
        css [
            style.backgroundColor color.red
            style.hover [
                style.backgroundColor color.blue
            ]
        ]
        str "Emotion"
    }
```