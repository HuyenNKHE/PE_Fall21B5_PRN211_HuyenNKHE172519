﻿using System;
using System.Collections.Generic;

namespace Q2.DataAccess;

public partial class Project
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime? StartDate { get; set; }

    public string? Type { get; set; }

    public int? Department { get; set; }

    public virtual Department? DepartmentNavigation { get; set; }
}
