1. Goal<br>
   Avoid coupling the sender of a request to its receiver by giving more than one object a chance to handle the request.<br>
   Chain the receiving objects and pass the request along the chain until an object handles it.
2. Participants<br>
   - Handler<br>
     - Represented by "HiringProcess" abstract class.
   - Concrete Handler
     - Represented by "HRAnalyst", "Manager" and "Doctor" are those who can handle the request it is responsible for.
     - Can access its successor.
     - If the ConcreteHandler can handle the request, it does so; otherwise it forwards the request to its successor.
   - Client
     - Represented by "ChainDemo".
     - Initiates the request to a ConcreteHandler object on the chain
3. Class Diagram
   ![Class Diagram](ChainOfResponsability_ClassDiagram.png)
4. In execution...
   ![Console App Execution](chainExecution.png)
