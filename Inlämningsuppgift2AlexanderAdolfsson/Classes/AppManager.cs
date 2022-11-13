using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inlämningsuppgift2AlexanderAdolfsson.Models;
using Inlämningsuppgift2AlexanderAdolfsson.Repository;
using Inlämningsuppgift2AlexanderAdolfsson.Views;

namespace Inlämningsuppgift2AlexanderAdolfsson.Classes
{
    public class AppManager
    {
        CustomerRepo customerRepo = new CustomerRepo();
        RoomRepo roomRepo = new RoomRepo();
        BookingRepo bookingRepo = new BookingRepo();
        InvoiceRepo invoiceRepo = new InvoiceRepo();
        public void OpenCustomerForm()
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.ShowDialog();
        }
        public void OpenBookingForm()
        {
            BookingForm bookingForm = new BookingForm();
            bookingForm.ShowDialog();
        }
        public void OpenInvoiceForm()
        {
            InvoiceForm invoiceForm = new InvoiceForm();
            invoiceForm.ShowDialog();
        }
        public void TryCustomerAdd(string name,string email,string phone)
        {
            List<Customer> customerList = customerRepo.GetAllCustomers();
            if(name == "" || email == "")
            {
                MessageBox.Show("Du måste fylla i Namn och Email");
                return;
            }
            else
            {
                if (phone == "")
                {
                    if (customerList.Any(x => x.Email == email))
                    {
                        MessageBox.Show("En kund med den mailen är redan registrerad");
                        return;
                    }
                    else
                        CustomerAdd(name, email);
                }
                else
                {
                    if (customerList.Any(x => x.Email == email))
                    {
                        MessageBox.Show("En kund med den mailen är redan registrerad");
                        return;
                    }
                    else
                        CustomerAdd(name, email, phone);
                }
                    
                
            }
        }
        private void CustomerAdd(string name,string email)
        {
            Customer customer = new Customer();
            customer.Name = name;
            customer.Email = email;
            customerRepo.InsertCustomer(customer);
            MessageBox.Show("Kund tillagd i systemet");
        }
        private void CustomerAdd(string name,string email,string phone)
        {
            Customer customer = new Customer();
            customer.Name = name;
            customer.Email = email;
            customer.Phone = phone;
            customerRepo.InsertCustomer(customer);
            MessageBox.Show("Kund tillagd i systemet");
        }
        public static Customer ShowCustomer(int valueMember)
        {
            CustomerRepo repo = new CustomerRepo();
            List<Customer> customerList = repo.GetAllCustomers();

            Customer choosenCustomer = customerList.Where(c => c.CustomerID == valueMember).SingleOrDefault();

            return choosenCustomer;
        }
        public void TryCustomerUpdate(int customerID,string name,string email,string phone)
        {
            if (customerID == 0)
                MessageBox.Show("Du måste välja en kund att uppdatera");

            else
            {
                if (name == "" || email == "")
                {
                    MessageBox.Show("Du måste fylla i Namn och Email");
                    return;
                }
                else
                {
                    if (phone == "")
                    {
                        phone = null;
                        Customer customer = new Customer();
                        customer.CustomerID = customerID;
                        customer.Name = name;
                        customer.Email = email;
                        customer.Phone = phone;
                        customerRepo.UpdateCustomer(customer);
                        MessageBox.Show("Kund uppdaterad");
                    }
                        
                    else
                    {
                        Customer customer = new Customer();
                        customer.CustomerID = customerID;
                        customer.Name = name;
                        customer.Email = email;
                        customer.Phone = phone;
                        customerRepo.UpdateCustomer(customer);
                        MessageBox.Show("Kund uppdaterad");
                    }
                    
                }
                
            }

        }
        public void TryCustomerDelete(int customerID)
        {
            List<Booking> bookings = new List<Booking>();
            if (customerID == 0)
                MessageBox.Show("Du måste välja en kund att uppdatera");

            else
            {
                if (bookings.Any(b => b.CustomerID == customerID))
                    MessageBox.Show("Du kan inte ta bort en kund som är bokad på ett rum");

                else
                {
                    customerRepo.DeleteCustomer(customerID);
                    MessageBox.Show("Kund borttagen i systemet");
                }
                
            }
                
        }
        public List<Room> AvailableRooms(DateTime startDate,DateTime endDate,int noOfPersons)
        {
            List<Room> allRooms = roomRepo.GetAllRooms();
            List<Booking> bookingsList = SortBookingTime(startDate, endDate);
            List<Room> availableRooms = allRooms.Where(a => !bookingsList.Select(b => b.RoomID).Contains(a.RoomID)).ToList();

            if (noOfPersons == 1)
            {
                return availableRooms;
            }
            else if (noOfPersons == 2)
            {
                List<Room> returnRooms = availableRooms.Where(a => a.RoomType.DoubleRoom == true).ToList();
                return returnRooms;
            }
            else if (noOfPersons == 3)
            {
                List<Room> returnRooms = availableRooms.Where(a => a.RoomType.ExtraBeds >= 1).ToList();
                return returnRooms;
            }
            else if (noOfPersons == 4)
            {
                List<Room> returnRooms = availableRooms.Where(a => a.RoomType.ExtraBeds == 2).ToList();
                return returnRooms;
            }
            else
            {
                MessageBox.Show("Du har angivit ett felaktigt antal personer");
                return null;
            }
                
            

        }
        private List<Booking> SortBookingTime(DateTime startDate,DateTime endDate)
        {
            List<Booking> allBookings = bookingRepo.GetAllBookings();
            List<Booking> sortedBookings = allBookings.Where(b => (b.StartDate <= endDate || b.StartDate >= startDate) && (b.EndDate <= endDate || b.EndDate >= startDate)).ToList();
            return sortedBookings;
        }
        public void CreateBooking(int customerID,int roomID,DateTime startDate,DateTime endDate)
        {
            Invoice invoice = new Invoice();
            invoice.IssueDate = DateTime.Now;
            invoice.ExpireDate = DateTime.Now.AddDays(10);
            invoice.IsPayed = false;
            invoiceRepo.InsertInvoice(invoice);

            List<Invoice> invoiceList = invoiceRepo.GetAllInvoice();
            int latestInvoiceID = invoiceList.Max(b => b.InvoiceID);

            Booking booking = new Booking();
            booking.InvoiceID = latestInvoiceID;
            booking.CustomerID = customerID;
            booking.RoomID = roomID;
            booking.StartDate = startDate;
            booking.EndDate = endDate;

            bookingRepo.InsertBooking(booking);
        }

    }
}
