using Microsoft.Extensions.DependencyInjection;
using YSKProje.Business.Concrete;
using YSKProje.Business.Interfaces;
using YSKProje.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using YSKProje.DataAccess.Interfaces;

namespace YSKProje.Business.Containers.MicrosoftIoC
{
    public static class CustomIoCExtension
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericDal<>), typeof(EfGenericRepository<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));

            services.AddScoped<IBlogDal,EfBlogRepository>();
            services.AddScoped<IAppUserDal,EfAppUserRepository>();
            services.AddScoped<ICategoryBlogDal,EfCategoryBlogRepository>();
            services.AddScoped<ICategoryDal,EfCategoryRepository>();
            services.AddScoped<ICommentDal,EfCommentRepository>();

            services.AddScoped<IBlogService, BlogManager>();
            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<ICategoryBlogService, CategoryBlogManager>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICommentService, CommentManager>();
        }
    }
}
