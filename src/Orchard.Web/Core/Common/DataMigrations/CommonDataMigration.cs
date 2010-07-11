﻿using System;
using Orchard.Data.Migration;

namespace Orchard.Core.Common.DataMigrations {
    public class CommonDataMigration : DataMigrationImpl {

        public int Create() {
            //CREATE TABLE Common_BodyRecord (Id INTEGER not null, Text TEXT, Format TEXT, ContentItemRecord_id INTEGER, primary key (Id));
            SchemaBuilder.CreateTable("BodyRecord", table => table
                .ContentPartVersionRecord()
                .Column<string>("Text", column => column.WithLength(10000))
                .Column<string>("Format")
                );

            //CREATE TABLE Common_CommonRecord (Id INTEGER not null, OwnerId INTEGER, CreatedUtc DATETIME, PublishedUtc DATETIME, ModifiedUtc DATETIME, Container_id INTEGER, primary key (Id));
            SchemaBuilder.CreateTable("CommonRecord", table => table
                .ContentPartRecord()
                .Column<int>("OwnerId")
                .Column<DateTime>("CreatedUtc")
                .Column<DateTime>("PublishedUtc")
                .Column<DateTime>("ModifiedUtc")
                .Column<int>("Container_id")
                );
            
            //CREATE TABLE Common_CommonVersionRecord (Id INTEGER not null, CreatedUtc DATETIME, PublishedUtc DATETIME, ModifiedUtc DATETIME, ContentItemRecord_id INTEGER, primary key (Id));
            SchemaBuilder.CreateTable("CommonVersionRecord", table => table
                .ContentPartVersionRecord()
                .Column<DateTime>("CreatedUtc")
                .Column<DateTime>("PublishedUtc")
                .Column<DateTime>("ModifiedUtc")
                );
            
            //CREATE TABLE Common_RoutableRecord (Id INTEGER not null, Title TEXT, Slug TEXT, Path TEXT, ContentItemRecord_id INTEGER, primary key (Id));
            SchemaBuilder.CreateTable("RoutableRecord", table => table
                .ContentPartVersionRecord()
                .Column<string>("Title", column => column.WithLength(1024))
                .Column<string>("Slug")
                .Column<string>("Path", column => column.WithLength(2048))
                );

            return 0010;
        }
    }
}