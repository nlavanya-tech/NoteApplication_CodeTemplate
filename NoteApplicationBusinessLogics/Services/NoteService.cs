using NoteApplication.BusinessLogics.Interface;
using NoteApplication.BusinessLogics.Services.Repository;
using NoteApplication.Database;
using NoteApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApplication.BusinessLogics.Services
{
    public class NoteService : INoteService
    {
        //create local instance 
        private readonly INoteRepository _repositary;

        public NoteService(INoteRepository repositary)
        {
            _repositary = repositary;
        }

        
        //Get Notes and retrun list of notes
        public async Task<IEnumerable<Notes>> ReadAsync()
        {
            var notes = await _repositary.ReadAsync();
            return notes;
        }
        //Create notes
        public async Task<Notes> CreateAsync(Notes notes)
        {
            await _repositary.CreateAsync(notes);
            return notes;
        }
        //Update Notes
        public async Task<Notes> UpdateAsync(Notes notes)
        {
            var note = await _repositary.UpdateAsync(notes);
            
            return note;
        }
        //Delete Notes 
        public async Task<Notes> DeleteAsync(Notes notes)
        {
            var result = await _repositary.DeleteAsync(notes);
            return result;
        }
    }
}

