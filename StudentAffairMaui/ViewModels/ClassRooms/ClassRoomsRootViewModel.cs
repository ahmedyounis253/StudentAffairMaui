﻿using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace StudentAffairMaui.ViewModels;

public partial class ClassRoomsRootViewModel : BaseRootsViewModel<ClassRoom,ClassRoomsForm>
{
   
    public ClassRoomsRootViewModel(IClassRoomsService teachersService) : base(teachersService)
    {
    }
    [ICommand]
    public void GetClassRooms() => base.GetEntities();

    [ICommand]
    public async Task AddClassRoom() => await base.AddEntity();
}
