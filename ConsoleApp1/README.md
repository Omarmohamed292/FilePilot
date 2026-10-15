# C# Console File Manager

A simple command-line File Manager built with C# and .NET. The application allows users to manage files and directories through text-based commands.

## Features

- **List** — Display files and directories inside a specified path.
- **Info** — Show file or directory information, including creation time and modification details.
- **Read** — Read and display the contents of a text file.
- **Write** — Append text to an existing file.
- **Create Directory** — Create a new directory.
- **Create File** — Create a new file while checking whether it already exists.
- **Remove** — Delete a file or an empty directory.
- **Change Directory** — Change the current working directory.
- **Copy** — Copy a file to another location.
- **Move** — Move a file to another location.
- **Error Handling** — Handle errors during file copy and move operations.

## Technologies Used

- C#
- .NET
- .NET System.IO APIs
- Console Application

## Getting Started

### Prerequisites

- .NET SDK
- Visual Studio or another C#-compatible development environment

### Installation

1. Clone the repository:

   ```bash
   git clone <https://github.com/Omarmohamed292/FilePilot.git>
   ```

2. Open the project in Visual Studio.

3. Build and run the application.

   Alternatively, navigate to the project directory and run:

   ```bash
   dotnet run
   ```

## Available Commands

| Command | Description | Example |
|---|---|---|
| `list` | List files and directories | `list C:\Users` |
| `info` | Display file or directory information | `info C:\Users\file.txt` |
| `read` | Display file contents | `read C:\Users\file.txt` |
| `write` | Append text to a file | `write C:\Users\file.txt` |
| `mkdir` | Create a directory | `mkdir C:\Users\NewFolder` |
| `mkfile` | Create a file | `mkfile C:\Users\new.txt` |
| `remove` | Delete a file or empty directory | `remove C:\Users\new.txt` |
| `cd` | Change the current directory | `cd C:\Users` |
| `copy` | Copy a file | `copy C:\source.txt\|C:\destination.txt` |
| `move` | Move a file | `move C:\source.txt\|C:\destination.txt` |
| `stop` | Exit the application | `stop` |

**Note:** Replace the example paths with valid paths on your computer. For `copy` and `move`, separate the source and destination paths using the `|` character.

## How It Works

The application reads commands from the console, separates each command from its arguments, and uses a `switch` statement to execute the requested operation.

File and directory operations are handled using .NET's `System.IO` classes, including `File`, `Directory`, `FileInfo`, and `DirectoryInfo`.

## Learning Objectives

This project provides practical experience with:

- C# strings and string manipulation
- Loops and conditional statements
- `switch` statements
- Methods and program flow
- File and directory operations
- Exception handling using `try-catch`
- Working with the .NET `System.IO` namespace

## Future Improvements

- Add a `help` command to display command usage.
- Improve input validation and error messages.
- Support paths containing spaces and quotation marks.
- Add more detailed file and directory information.
- Organize commands into separate methods.
- Improve exception handling for file system operations.

## License

This project is available for educational and personal learning purposes.
