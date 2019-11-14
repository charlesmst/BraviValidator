This is a simple validator of expressions with brackets in a dotnet console application. It takes a string of brackets as the input, and determines if the order of the brackets is valid. A bracket is considered to be any one of the following characters: (, ), {, }, [, or ].

Examples:
- `(){}[]` is valid
-  `[{()}](){}` is valid
-  `[]{()` is not valid
-  `[{)]` is not valid
## Running app
Enter the project folder.
### `cd src/App`
Execute the app with the formula to validate as first argument.
### `dotnet run <formula-to-validate>`
The app will output "Valid Sequence" when the formula is valid and an error when it receives a invalid input.
## Tests


Enter the test project folder.
### `cd tests/AppTests`
Execute the app with the formula to validate as first argument.
### `dotnet test`
