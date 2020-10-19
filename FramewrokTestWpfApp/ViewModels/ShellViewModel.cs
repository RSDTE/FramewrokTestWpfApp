using Caliburn.Micro;
using FramewrokTestWpfApp.Interfaces;
using FramewrokTestWpfApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace FramewrokTestWpfApp.ViewModels
{
    public class ShellViewModel : Caliburn.Micro.PropertyChangedBase, IShell
    {
        public BindableCollection<PersonInfo> Items {
            get {
                return this.items;
            }

            set {
                this.items = value;
            }
        }

        private BindableCollection<PersonInfo> items;

        private ObservableCollection<Staff> _StaffList = new ObservableCollection<Staff>();

        public ObservableCollection<Staff> StaffList {
            get { return _StaffList; }

            set {
                _StaffList = value;
                this.NotifyOfPropertyChange(nameof(StaffList));
            }
        }

        public ShellViewModel() {

            #region test

            Items = new BindableCollection<PersonInfo>() {
                new PersonInfo{
                    FullName = "Bruce Cambell",
                    JobTitle = "Chief Executive Officer",
                    Country = "Japan",
                    BirthDate = new DateTime(1957, 9, 6),
                    Phone = "(417)166-3268",
                    Children = new BindableCollection<PersonInfo>() {
                        new PersonInfo {
                            FullName = "Cindy Haneline",
                            JobTitle = "Information Services Manager",
                            Country = "Singapore",
                            BirthDate = new DateTime(1973, 12, 23),
                            Phone = "(918)161-3649",
                            Children = null,
                        },
                        new PersonInfo {
                            FullName = "Carolyn Baker",
                            JobTitle = "Marketing Manager",
                            Country = "Hungary",
                            BirthDate = new DateTime(1978, 3, 23),
                            Phone = "(209)125-4334",
                            Children = new BindableCollection<PersonInfo>() {
                                new PersonInfo {
                                    FullName = "Anthony Rounds",
                                    JobTitle = "Marketing Specialist",
                                    Country = "Germany",
                                    BirthDate = new DateTime(1973, 1 ,4),
                                    Phone = "(559)453-3698",
                                    Children = null,
                                },
                                new PersonInfo {
                                    FullName = "Anthony Peterson",
                                    JobTitle = "Marketing Specialist",
                                    Country = "Germany",
                                    BirthDate = new DateTime(1971, 1, 4),
                                    Phone="(559)224-4648",
                                    Children = null,
                                },
                            }
                        }
                    }
                },
                new PersonInfo {
                    FullName = "Allison Etter",
                    JobTitle = "Research and Development Manager"
                    , Country = "United States",
                    BirthDate = new DateTime(1982, 2, 10),
                    Phone = "(703)826-9719",
                    Children = null,
                }
            };

            #endregion test

#if false

            #region sample

            Staff staff = new Staff() {
                Name = "����",
                Age = 30,
                Sex = "��",
                Duty = "����",
                IsExpanded = true
            };
            Staff staff2 = new Staff() {
                Name = "����1",
                Age = 21,
                Sex = "��",
                Duty = "Ա��",
                IsExpanded = true
            };
            Staff staff3 = new Staff() {
                Name = "����11",
                Age = 21,
                Sex = "��",
                Duty = "Ա��"
            };
            staff2.StaffList.Add(staff3);
            staff3 = new Staff() {
                Name = "����22",
                Age = 21,
                Sex = "Ů",
                Duty = "Ա��"
            };
            staff2.StaffList.Add(staff3);
            staff.StaffList.Add(staff2);
            staff2 = new Staff() {
                Name = "����2",
                Age = 22,
                Sex = "Ů",
                Duty = "Ա��"
            };
            staff.StaffList.Add(staff2);
            staff2 = new Staff() {
                Name = "����3",
                Age = 23,
                Sex = "Ů",
                Duty = "Ա��"
            };
            staff.StaffList.Add(staff2);
            StaffList.Add(staff);

            staff = new Staff() {
                Name = "����",
                Age = 31,
                Sex = "��",
                Duty = "������"
            };
            staff2 = new Staff() {
                Name = "����1",
                Age = 24,
                Sex = "Ů",
                Duty = "Ա��"
            };
            staff.StaffList.Add(staff2);
            staff2 = new Staff() {
                Name = "����2",
                Age = 25,
                Sex = "Ů",
                Duty = "Ա��"
            };
            staff.StaffList.Add(staff2);
            staff2 = new Staff() {
                Name = "����3",
                Age = 26,
                Sex = "��",
                Duty = "Ա��"
            };
            staff.StaffList.Add(staff2);
            StaffList.Add(staff);

            staff = new Staff() {
                Name = "����",
                Age = 32,
                Sex = "Ů",
                Duty = "�鳤"
            };
            staff2 = new Staff() {
                Name = "����1",
                Age = 27,
                Sex = "Ů",
                Duty = "Ա��"
            };
            staff.StaffList.Add(staff2);
            staff2 = new Staff() {
                Name = "����2",
                Age = 28,
                Sex = "Ů",
                Duty = "Ա��"
            };
            staff.StaffList.Add(staff2);
            StaffList.Add(staff);

            #endregion sample

#endif
        }
    }
}