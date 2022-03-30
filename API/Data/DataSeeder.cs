using API.Data.SeederDtos;
using API.Entities;
using AutoMapper;
using Newtonsoft.Json;
using RestSharp;

namespace API.Data;

public class DataSeeder
{
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;

    public DataSeeder(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task Seed()
    {
        if (!_context.Users.Any())
        {
            var client = new RestClient("https://random-data-api.com/api");

            var request = new RestRequest("users/random_user?size=100");

            var response = await client.GetAsync(request);

            var usersData = JsonConvert.DeserializeObject<List<UserSeedDto>>(response.Content);

            var usersMapped = _mapper.Map<List<User>>(usersData);

            request = new RestRequest("address/random_address?size=100");

            response = await client.GetAsync(request);

            var addressesData = JsonConvert.DeserializeObject<List<AddressSeedDto>>(response.Content);

            var addressesMapped = _mapper.Map<List<Address>>(addressesData);

            response = await client.GetAsync(request);

            addressesData = JsonConvert.DeserializeObject<List<AddressSeedDto>>(response.Content);

            addressesMapped.AddRange(_mapper.Map<List<Address>>(addressesData));

            for (int i = 0; i < usersMapped.Count; i++)
            {
                var userAddresses = new List<Address>
                {
                    addressesMapped[i],
                    addressesMapped[addressesMapped.Count - i - 1],
                };

                usersMapped[i].Addresses = userAddresses;
            }

            _context.Users.AddRange(usersMapped);

            await _context.SaveChangesAsync();
        }
    }
}
