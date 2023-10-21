using HotelBookingAutomation.Business.Abstract;
using HotelBookingAutomation.DataAcess.Abstract;
using HotelBookingAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingAutomation.Business.Concrete
{
    public class RoomManager:IRoomService
    {
        IRoomDal _roomDal;
        public RoomManager(IRoomDal roomDal)
        {
            _roomDal = roomDal;
        }

        public async Task DeleteRoomAsync(Room room)
        {
            try
            {
                await _roomDal.DeleteAsync(room);
            }catch (Exception ex) { }
        }

        public async Task<IEnumerable<RoomWithDetailsDto>> GetAllAvailableRoomsAsync(DateTime start,DateTime end)
        {
            try
            {
                return await _roomDal.GetAllAvailableAsync(start,end);
            }catch (Exception ex) { }
            return null;
        }

        public async Task<IEnumerable<RoomWithDetailsDto>> GetAllBookedRoomsAsync(DateTime start, DateTime end)
        {
            try
            {
                return await _roomDal.GetAllBookedAsync(start, end);
            }
            catch (Exception ex) { }
            return null;
        }

        public async Task<IEnumerable<Room>> GetAllRoomsAsync()
        {
            try
            {
                return await _roomDal.GetAllAsync();
            }
            catch (Exception ex) { }
            return null;
        }

        public async Task<IEnumerable<RoomWithDetailsDto>> GetAllRoomsWithDetailsAsync()
        {
            try
            {
                return await _roomDal.GetAllWithDetailsAsync();
            }catch (Exception ex) { }
            return null;
        }

        public async Task<Room> GetRoomByIdAsync(Guid id)
        {
            try
            {
                return await _roomDal.GetByIdAsync(id);
            }
            catch (Exception ex) { }
            return null;
        }

        public async Task<Room> GetRoomByUniqueRoomNo(string uniqueRoomNo)
        {
            try
            {
                return await _roomDal.GetByUniqueNoAsync(uniqueRoomNo);
            }
            catch (Exception ex) { }
            return null;
        }

        public async Task InsertRoomAsync(Room room)
        {
            try
            {
                room.UniqueRoomNo=((room.Floor*100)+room.RoomNo).ToString();
                await _roomDal.InsertAsync(room);
            }
            catch (Exception ex) { }
        }

        public async Task UpdateRoomAsync(Room room)
        {
            try
            {
                room.UniqueRoomNo = ((room.Floor * 100) + room.RoomNo).ToString();
                await _roomDal.UpdateAsync(room);
            }
            catch (Exception ex) { }
        }
    }
}
