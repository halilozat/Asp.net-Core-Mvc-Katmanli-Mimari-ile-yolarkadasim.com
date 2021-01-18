using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace YolArkadasim.Data.Migrations
{
    public partial class SeedingCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "INSERT INTO [YolArkadasim].dbo.Categories (Name,Description,Note,CreatedDate,CreatedByName,ModifiedDate,ModifiedByName,IsActive,IsDeleted) " +
                "VALUES ('Kamyon','Kamyon','Kamyon Kategorisi',GETDATE(),'Migration',GETDATE(),'Migration',1,0)");
            migrationBuilder.Sql(
                "INSERT INTO [YolArkadasim].dbo.Categories (Name,Description,Note,CreatedDate,CreatedByName,ModifiedDate,ModifiedByName,IsActive,IsDeleted) VALUES ('Tır','Tır ile İlgili En Güncel Bilgiler','Tır Kategorisi',GETDATE(),'Migration',GETDATE(),'Migration',1,0)");
            migrationBuilder.Sql(
                "INSERT INTO [YolArkadasim].dbo.Categories (Name,Description,Note,CreatedDate,CreatedByName,ModifiedDate,ModifiedByName,IsActive,IsDeleted) VALUES ('Taksi','Taksi ile İlgili En Güncel Bilgiler','Taksi Kategorisi',GETDATE(),'Migration',GETDATE(),'Migration',1,0)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
