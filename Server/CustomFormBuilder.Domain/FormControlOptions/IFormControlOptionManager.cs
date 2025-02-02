﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFormBuilder.Domain.FormControlOptions
{
    public interface IFormControlOptionManager
    {
        Task<FormControlOption> CreateAsync(string value, string displayText, Guid formControlId);
        Task UpdateAsync(Guid id, string value, string displayText);
        Task DeleteAsync(Guid id);
    }
}
