using MauiApp3.Controls;
using MauiApp3.Views.Homepage;
using MauiApp3.Views.Startup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp3.Models
{
    public class AppConstant
    {
        public async static Task AddFlyoutMenusDetails()
        {
            AppShell.Current.FlyoutHeader = new FlyoutHeaderControl();

            var studentInfo = AppShell.Current.Items.Where(f => f.Route == nameof(StudentPage)).FirstOrDefault();
            if (studentInfo != null) AppShell.Current.Items.Remove(studentInfo);

            var teacherInfo = AppShell.Current.Items.Where(f => f.Route == nameof(TeacherPage)).FirstOrDefault();
            if (teacherInfo != null) AppShell.Current.Items.Remove(teacherInfo);

            if (App.UserDetails.RoleID == (int)RoleDetails.Student)
            {
                var flyoutItem = new FlyoutItem()
                {
                    Title = "Dashboard Page",
                    Route = nameof(StudentPage),
                    FlyoutDisplayOptions = FlyoutDisplayOptions.AsMultipleItems,
                    Items =
                            {
                                new ShellContent
                                {
                                    Icon = Icons.Dashboard,
                                    Title = "Student Dashboard",
                                    ContentTemplate = new DataTemplate(typeof(StudentPage)),
                                },
                                new ShellContent
                                {
                                    Icon = Icons.AboutUs,
                                    Title = "Student Profile",
                                    ContentTemplate = new DataTemplate(typeof(StudentPage)),
                                },
                            }
                };
                if (!AppShell.Current.Items.Contains(flyoutItem))
                {
                    AppShell.Current.Items.Add(flyoutItem);
                    if (DeviceInfo.Platform == DevicePlatform.WinUI)
                    {
                        AppShell.Current.Dispatcher.Dispatch(async () =>
                        {
                            await Shell.Current.GoToAsync($"//{nameof(StudentPage)}");
                        });
                    }
                    else
                    {
                        await Shell.Current.GoToAsync($"//{nameof(StudentPage)}");
                    }
                }

            }

            if (App.UserDetails.RoleID == (int)RoleDetails.Teacher)
            {
                var flyoutItem = new FlyoutItem()
                {
                    Title = "Dashboard Page",
                    Route = nameof(TeacherPage),
                    FlyoutDisplayOptions = FlyoutDisplayOptions.AsMultipleItems,
                    Items =
                    {
                                new ShellContent
                                {
                                    Icon = Icons.Dashboard,
                                    Title = "Teacher Dashboard",
                                    ContentTemplate = new DataTemplate(typeof(TeacherPage)),
                                },
                                new ShellContent
                                {
                                    Icon = Icons.AboutUs,
                                    Title = "Teacher Profile",
                                    ContentTemplate = new DataTemplate(typeof(TeacherPage)),
                                },
                   }
                };

                if (!AppShell.Current.Items.Contains(flyoutItem))
                {
                    AppShell.Current.Items.Add(flyoutItem);
                    if (DeviceInfo.Platform == DevicePlatform.WinUI)
                    {
                        AppShell.Current.Dispatcher.Dispatch(async () =>
                        {
                            await Shell.Current.GoToAsync($"//{nameof(TeacherPage)}");
                        });
                    }
                    else
                    {
                        await Shell.Current.GoToAsync($"//{nameof(TeacherPage)}");
                    }
                }
            } 
        }
    }
}
