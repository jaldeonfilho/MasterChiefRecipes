namespace Models.Mappers
{
    public static class UserMapper
    {
        public static UserDto ToDto(User entity)
        {
            if (entity == null)
                return null;

            return new UserDto
            {
                Id = entity.Id,
                Name = entity.Name,
                Email = entity.Email,
                Favourites = entity.Favourites,
                IsAdmin = entity.IsAdmin,
                IsAtive = entity.IsAtive,
                IsRegisted = entity.IsRegisted,
                Password = entity.Password,
                Recipes = entity.Recipes,
            };
        }
        public static IEnumerable<UserDto> ToDtos(IEnumerable<User> entities)
        {
            if (entities == null)
                return Enumerable.Empty<UserDto>();

            return entities.Select(e => ToDto(e));
        }
        public static User ToEntity(UserDto viewModel)
        {
            if (viewModel == null)
                return null;

            return new User
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Email = viewModel.Email,
                Favourites = viewModel.Favourites,
                IsAdmin = viewModel.IsAdmin,
                IsAtive = viewModel.IsAtive,
                IsRegisted = viewModel.IsRegisted,
                Password = viewModel.Password,
                Recipes = viewModel.Recipes,
            };
        }
    }
}
