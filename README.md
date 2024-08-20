# RosalindSolver

RosalindSolver is an open-source project designed to solve various bioinformatics problems from the Rosalind platform. This project showcases coding exercises and allows others to collaborate and contribute to solving more problems.

## Table of Contents

- [Overview](#overview)
- [Installation](#installation)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)

## Overview

RosalindSolver is a console application that provides solutions to bioinformatics problems. The project is structured to separate concerns into different projects, making it easy to maintain and extend. The current implementation includes solutions for problems such as counting nucleotides, transcribing DNA into RNA, finding DNA complements, and more.

## Installation

To get started with RosalindSolver, follow these steps:

1. **Clone the repository:**
```
    git clone https://github.com/gncube/RosalindSolver.git
    cd RosalindSolver
```
      
2. **Build the project:**

    Open the solution in Visual Studio and build the project, or use the .NET CLI:
```
    dotnet build
```
3. **Run the tests:**
```
    dotnet tests
```


## Usage

To run the application, use the following command:
```
    dotnet run --project src/Rosalind.UI
```


You will be prompted to select an operation from the list of available options. Follow the on-screen instructions to provide the necessary input.

### Available Operations

1. Count nucleotides
2. Transcribe DNA into RNA
3. Find the complement of DNA
4. Calculate rabbit pairs
5. Calculate mortal rabbit pairs
6. Compute highest GC content
7. Find motif locations in DNA  

    