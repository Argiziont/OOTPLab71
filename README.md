---------------------------------------English

Develop a technical task. Show the decomposition of the task, where some of the tasks should be implemented using generating patterns:
- Memento. 
- Visitor.    

Technical task.

The technical task: Report generator

A tool is required that can generate reports in various formats (PDF, CSV, Excel), based on various filters and sorting criteria. The system should be able to handle large data sets and be scalable. 

Requirements:

- The report generator must be implemented in C#.

- The generator should be developed using the Memento and Visitor templates.

- The system should be able to generate reports in PDF, CSV and Excel formats.

- The system should be able to process large data sets.

- The system must be scalable.

- The system must be able to apply various filters and sorting criteria to the data. 

Deliverables:

- C# code that implements the report generator using Memento and Visitor.

- Unit tests that verify the functionality of the report generator.


The Memento template will be used to save the state of the report generator at different points in time. This will allow users to undo and redo actions as needed.
The Visitor template will be used to generate different report formats. Each format (PDF, CSV, Excel) will have its own visitor class that implements the logic of report generation. The report generator will accept the visitor object and call the appropriate visit method to generate the report in the desired format.

To handle large datasets, the report generator will use pagination to retrieve data in portions rather than all at once. The system will also be designed to be scalable, allowing additional resources to be added as needed.

Finally, the report generator will allow users to apply various filters and sorting criteria to the data. These filters and criteria will be applied before the data is passed to the visitor's facility for report generation.


Deliverables:
- C# code that implements the report generator using Interpreter and Mediator.
- Unit tests that check the functionality of the report generator.

The interpreter template will be used to analyze and interpret user-selected filters and sorting criteria. This will allow us to create a flexible and extensible system that can handle a variety of filtering and sorting parameters.

The Mediator template will be used to handle the communication between different components of the system (for example, the user interface, the reporting engine, and the data storage layer). This will allow us to separate the components and make the system more modular and easier to maintain.

Overall, the use of these two patterns will help us create a robust and scalable report generation system that can handle large data sets and be customized to meet the needs of different users.
---------------------------------------Українська

Розробити технічне завдання. Показати декомпонування завдання, де частина завдань має бути реалізована з використанням породжуючих патернів:
-	Зберігач (Memento). 

-	Відвідувач (Visitor).    

Технічне завдання

Технічне завдання: Генератор репортів
Потрібен інструмент, який може генерувати звіти в різних форматах (PDF, CSV, Excel), на основі різних фільтрів і критеріїв сортування. Система повинна мати можливість обробляти великі набори даних і бути масштабованою. 

Вимоги:
•	Генератор звітів повинен бути реалізований на C#.

•	Генератор має бути розроблений за допомогою шаблонів Memento і Visitor.

•	Система повинна мати можливість створювати звіти у форматах PDF, CSV та Excel.

•	Система повинна мати можливість обробляти великі набори даних.

•	Система повинна бути масштабованою.

•	Система повинна мати можливість застосовувати різні фільтри та критерії сортування до даних. 

Результати роботи:

•	Код C#, який реалізує генератор звітів за допомогою Memento і  Visitor.

•	Модульні тести, які перевіряють функціональність генератора звітів.


Шаблон Memento використовуватиметься для збереження стану генератора звітів у різні моменти часу. Це дозволить користувачам скасовувати та повторювати дії за потреби.
Шаблон відвідувача буде використано для створення різних форматів звітів. 

Кожен формат (PDF, CSV, Excel) матиме власний клас відвідувачів, який реалізує логіку формування звіту. Генератор звітів прийме об’єкт відвідувача та викличе відповідний метод відвідування, щоб створити звіт у потрібному форматі.

Щоб обробляти великі набори даних, генератор звітів використовуватиме розбиття на сторінки, щоб отримувати дані порціями, а не всі одночасно. Система також буде розрахована на масштабування, що дозволить додавати додаткові ресурси за потреби.

Нарешті, генератор звітів дозволить користувачам застосовувати різні фільтри та критерії сортування до даних. Ці фільтри та критерії будуть застосовані до того, як дані будуть передані об’єкту відвідувача для створення звіту.
