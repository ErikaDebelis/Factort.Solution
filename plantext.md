migration code to start entity framework core projects

``dotnet tool install --global dotnet-ef --version 3.0.0``

`` dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0``

``dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2``

``dotnet ef migrations add Initial``



    [HttpPost]
    public ActionResult Create(string EngineerName, string MachineName, int EngineerId, Machine machine)
    {
      int newEngineerId = EngineerId;

      if (EngineerName != null)
      {
        Engineer newEngineer = new Engineer();
        newEngineer.Name = EngineerName;
        _db.Engineers.Add(newEngineer);
        _db.SaveChanges();
        newEngineerId = newEngineer.EngineerId;
      }
      _db.Machines.Add(machine);
      _db.EngineerMachine.Add(new EngineerMachine() { EngineerId = EngineerId, MachineId = machine.MachineId });
      _db.SaveChanges();

      return RedirectToAction("Index");
    }