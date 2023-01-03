using GraphQL.Types;

namespace GraphQLNetExample.Notes;

public class NotesQuery : ObjectGraphType
{
  public NotesQuery()
  {
    Field<ListGraphType<NoteType>>("notes", resolve: context => new List<Note> {
      new Note { Id = Guid.NewGuid(), Message = "Hello World!", Age=1 },
      new Note { Id = Guid.NewGuid(), Message = "Hello World! How are you?", Age=2 },
      new Note { Id = Guid.NewGuid(), Message = null, Age = 3 }
    });
  }
}