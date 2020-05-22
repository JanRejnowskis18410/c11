using Cwiczenia11.DTOs;
using Cwiczenia11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cwiczenia11.Services
{
    public interface IDoctorDbService
    {
        public IEnumerable<Doctor> GetDoctors();
        public void DeleteDoctor(int id);
        public void CreateDoctor(Doctor doctor);
        public void UpdateDoctor(UpdateDoctorRequest request, int id);
    }
}
