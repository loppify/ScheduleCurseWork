## Schedule - Event and Time Management Utility 📅

A desktop application designed using C\# and the .NET framework for efficient personal time management, allowing users to schedule, track, and manage one-time and recurring maintenance events.

This project was a practical exercise in applying core **Object-Oriented Programming (OOP)** principles and handling data persistence within a C\# environment.

-----

### Key Features

  * **Event Scheduling:** Create and categorize detailed one-time events and recurring maintenance tasks.
  * **Time Management:** Simple, intuitive interface for managing time allocations and viewing upcoming schedules.
  * **Data Persistence:** Reliable saving and loading of all event data across sessions.

-----

### Technology Stack

| Category | Technology | Purpose |
| :--- | :--- | :--- |
| **Language** | **C\#** | Primary programming language. |
| **Framework** | **.NET (Framework/Core)** | Core platform providing libraries and runtime environment. |
| **UI/Platform** | **Windows Forms (WinForms)** | Graphical user interface development for a native Windows desktop experience. |
| **Concepts** | **Object-Oriented Programming (OOP)** | Architecture built around classes and objects for modularity. |

-----

### Technical Highlights (What I Built)

This project focused on robust software design, showcasing the application of fundamental computer science principles.

  * **OOP Implementation:** Extensively utilized **OOP** concepts (classes, inheritance, encapsulation) to model real-world entities like `Event`, `Task`, and `Schedule`, ensuring the codebase is modular and easy to extend.
  * **Persistent Data Handling:** Developed a mechanism (file serialization) for securely and reliably saving the user's event data, overcoming initial challenges with state management.
  * **Modular Architecture:** Designed the UI logic (WinForms) to be cleanly separated from the core business logic, a best practice for maintainable desktop applications.
  * **User Interface:** Built a functional, native user interface that focuses on usability for scheduling and data input.

-----

### Installation and Running Locally

Follow these steps to set up and run the application on your local machine.

#### Prerequisites

You must have the following installed:

  * **Visual Studio** (Recommended IDE)
  * The appropriate **.NET Framework** or **.NET Core** version used for development.

#### Setup

1.  **Clone the repository:**

    ```bash
    git clone https://github.com/loppify/ScheduleCurseWork.git
    cd ScheduleCurseWork
    ```

2.  **Open in Visual Studio:**

      * Open the solution file (`.sln`) in Visual Studio.
      * Ensure all project dependencies and target frameworks are correctly set.

3.  **Run the application:**

      * Build the solution.
      * Run the project (usually by pressing **F5** or clicking the **Start** button).

-----

### Future Improvements

  * Implement a more scalable database solution (e.g., SQLite or local SQL Server Express) instead of the current data saving mechanism.
  * Enhance the calendar and view components for better visual data representation.
  * Add unit testing to validate core scheduling and persistence logic.

-----

**Author:** Rostyslav Tarasov
**GitHub:** [github.com/loppify](https://github.com/loppify)
