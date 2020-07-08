using NoteApplication.Database;
using NoteApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace NoteApplication.BusinessLogics.Services.Repository
{
    public class NoteRepository : INoteRepository
    {
        //create local instance for InmemoryDb
        private InMemoryDb DbContext;
        public NoteRepository(InMemoryDb DbContext)
        {
            this.DbContext = DbContext;
        }
          //Get notes from Inmemory db   
        public async Task<IEnumerable<Notes>> ReadAsync()
        {
            throw new NotImplementedException();
        }
        //Add notes into Inmemory Db and return notes
        public async Task<Notes> CreateAsync(Notes notes)
        {
            this.DbContext.Add(notes);
            this.DbContext.SaveChanges();
            return notes;
        }
        //Update Notes into Inmemory Db and return notes 
        public async Task<Notes> UpdateAsync(Notes note)
        {
            throw new NotImplementedException();
        }
        //Delete Notes from INmemory Db and return Notes
        public async Task<Notes> DeleteAsync(Notes notes)
        {
            throw new NotImplementedException();
        }
    }
}
