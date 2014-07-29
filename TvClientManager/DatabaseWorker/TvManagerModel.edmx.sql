
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/29/2014 01:14:12
-- Generated from EDMX file: E:\Work\TVClientManager\TvClientManager\DatabaseWorker\TvManagerModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [TvClients];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ClientsSet'
CREATE TABLE [dbo].[ClientsSet] (
    [Id] uniqueidentifier  NOT NULL,
    [IsDelete] tinyint  NOT NULL,
    [CreateDate] datetime  NULL,
    [ModifiedDate] datetime  NOT NULL,
    [StateId] uniqueidentifier  NOT NULL,
    [ExecutorID] uniqueidentifier  NOT NULL,
    [BankInfoId] nvarchar(max)  NOT NULL,
    [LanguageId] uniqueidentifier  NOT NULL,
    [PayRate] float  NOT NULL,
    [CurrencyId] nvarchar(max)  NOT NULL,
    [Code] nvarchar(max)  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Telephone] nvarchar(max)  NOT NULL,
    [Comment] nvarchar(max)  NOT NULL,
    [RegisterDate] datetime  NOT NULL,
    [BlockedDate] datetime  NULL,
    [Executors_Id] uniqueidentifier  NOT NULL,
    [Languages_Id] uniqueidentifier  NOT NULL,
    [Currencies_Id] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'ChanelsSet'
CREATE TABLE [dbo].[ChanelsSet] (
    [Id] uniqueidentifier  NOT NULL,
    [IsDelete] tinyint  NOT NULL,
    [CreateDate] datetime  NOT NULL,
    [ModifiedDate] datetime  NOT NULL,
    [StateId] uniqueidentifier  NOT NULL,
    [LanguageId] uniqueidentifier  NOT NULL,
    [TimeOffSet] int  NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [FileName] nvarchar(max)  NOT NULL,
    [ChanelState_Id] uniqueidentifier  NOT NULL,
    [Languages_Id] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'ExecutorsSet'
CREATE TABLE [dbo].[ExecutorsSet] (
    [Id] uniqueidentifier  NOT NULL,
    [IsDelete] nvarchar(max)  NOT NULL,
    [CreateDate] nvarchar(max)  NOT NULL,
    [ModifiedDate] nvarchar(max)  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Comment] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'UserInfoSet'
CREATE TABLE [dbo].[UserInfoSet] (
    [Id] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Login] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [IsDelete] tinyint  NOT NULL,
    [CreateDate] datetime  NOT NULL,
    [ModifiedDate] datetime  NOT NULL,
    [IsAdmin] tinyint  NOT NULL
);
GO

-- Creating table 'TemplatesSet'
CREATE TABLE [dbo].[TemplatesSet] (
    [Id] uniqueidentifier  NOT NULL,
    [IsDelete] tinyint  NOT NULL,
    [CreateDate] datetime  NOT NULL,
    [ModifiedDate] datetime  NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Code] nvarchar(max)  NOT NULL,
    [TemplateParamType] uniqueidentifier  NULL
);
GO

-- Creating table 'TemplateParamsSet'
CREATE TABLE [dbo].[TemplateParamsSet] (
    [Id] uniqueidentifier  NOT NULL,
    [TemplateId] uniqueidentifier  NOT NULL,
    [TypeId] uniqueidentifier  NOT NULL,
    [ClientId] nvarchar(max)  NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Templates_Id] uniqueidentifier  NOT NULL,
    [Clients_Id] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'ClientChanelsSet'
CREATE TABLE [dbo].[ClientChanelsSet] (
    [Id] uniqueidentifier  NOT NULL,
    [ClientId] uniqueidentifier  NOT NULL,
    [ChanelId] uniqueidentifier  NOT NULL,
    [Chanels_Id] uniqueidentifier  NOT NULL,
    [Clients_Id] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'ClientStateSet'
CREATE TABLE [dbo].[ClientStateSet] (
    [Id] uniqueidentifier  NOT NULL,
    [IsDelete] nvarchar(max)  NOT NULL,
    [CreateDate] nvarchar(max)  NOT NULL,
    [ModifiedDate] nvarchar(max)  NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Code] nvarchar(max)  NOT NULL,
    [Clients_Id] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'ChanelStateSet'
CREATE TABLE [dbo].[ChanelStateSet] (
    [Id] uniqueidentifier  NOT NULL,
    [IsDelete] tinyint  NOT NULL,
    [CreateDate] datetime  NOT NULL,
    [ModifiedDate] datetime  NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Code] int  NOT NULL
);
GO

-- Creating table 'LanguagesSet'
CREATE TABLE [dbo].[LanguagesSet] (
    [Id] uniqueidentifier  NOT NULL,
    [IsDelete] tinyint  NOT NULL,
    [CreateDate] datetime  NOT NULL,
    [ModifiedDate] datetime  NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Code] int  NOT NULL
);
GO

-- Creating table 'CurrenciesSet'
CREATE TABLE [dbo].[CurrenciesSet] (
    [Id] uniqueidentifier  NOT NULL,
    [IsDelete] nvarchar(max)  NOT NULL,
    [CreateDate] nvarchar(max)  NOT NULL,
    [ModifiedDate] nvarchar(max)  NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Code] int  NOT NULL,
    [IsMain] tinyint  NOT NULL,
    [Cource] float  NOT NULL
);
GO

-- Creating table 'ContactPeopleSet'
CREATE TABLE [dbo].[ContactPeopleSet] (
    [Id] uniqueidentifier  NOT NULL,
    [IsDelete] tinyint  NOT NULL,
    [CreateDate] datetime  NOT NULL,
    [ModifiedDate] datetime  NOT NULL,
    [PositionId] uniqueidentifier  NOT NULL,
    [ClientId] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Telephone] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Clients_Id] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'PaymentsSet'
CREATE TABLE [dbo].[PaymentsSet] (
    [Id] uniqueidentifier  NOT NULL,
    [ClientId] uniqueidentifier  NOT NULL,
    [IsDelete] tinyint  NOT NULL,
    [CreateDate] datetime  NOT NULL,
    [ModifiedDate] datetime  NOT NULL,
    [PayDate] datetime  NOT NULL,
    [Paid] float  NOT NULL,
    [Dept] float  NOT NULL,
    [CurrencyId] nvarchar(max)  NOT NULL,
    [Clients_Id] uniqueidentifier  NOT NULL,
    [Currencies_Id] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'BanksInfoSet'
CREATE TABLE [dbo].[BanksInfoSet] (
    [Id] uniqueidentifier  NOT NULL,
    [IsDelete] tinyint  NOT NULL,
    [CreateDate] datetime  NOT NULL,
    [ModifiedDate] datetime  NOT NULL,
    [Clients_Id] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'PositionsSet'
CREATE TABLE [dbo].[PositionsSet] (
    [Id] uniqueidentifier  NOT NULL,
    [IsDelete] tinyint  NOT NULL,
    [CreateDate] datetime  NOT NULL,
    [ModifiedDate] datetime  NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Code] int  NOT NULL,
    [ContactPeople_Id] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'TemplateParamsTypeSet'
CREATE TABLE [dbo].[TemplateParamsTypeSet] (
    [Id] uniqueidentifier  NOT NULL,
    [IsDelete] tinyint  NOT NULL,
    [CreateDate] datetime  NOT NULL,
    [ModifiedDate] datetime  NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Code] int  NOT NULL,
    [Templates_Id] uniqueidentifier  NOT NULL,
    [TemplateParams_Id] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'FilesSet'
CREATE TABLE [dbo].[FilesSet] (
    [Id] uniqueidentifier  NOT NULL,
    [ClientId] uniqueidentifier  NOT NULL,
    [ChanelId] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [FileLocation] nvarchar(max)  NOT NULL,
    [CreateDate] datetime  NOT NULL,
    [Clients_Id] uniqueidentifier  NOT NULL,
    [Chanels_Id] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'FIleErrorSet'
CREATE TABLE [dbo].[FIleErrorSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ErrorDate] datetime  NOT NULL,
    [Details] nvarchar(max)  NOT NULL,
    [FileId] nvarchar(max)  NOT NULL,
    [Files_Id] uniqueidentifier  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ClientsSet'
ALTER TABLE [dbo].[ClientsSet]
ADD CONSTRAINT [PK_ClientsSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ChanelsSet'
ALTER TABLE [dbo].[ChanelsSet]
ADD CONSTRAINT [PK_ChanelsSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ExecutorsSet'
ALTER TABLE [dbo].[ExecutorsSet]
ADD CONSTRAINT [PK_ExecutorsSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UserInfoSet'
ALTER TABLE [dbo].[UserInfoSet]
ADD CONSTRAINT [PK_UserInfoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TemplatesSet'
ALTER TABLE [dbo].[TemplatesSet]
ADD CONSTRAINT [PK_TemplatesSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TemplateParamsSet'
ALTER TABLE [dbo].[TemplateParamsSet]
ADD CONSTRAINT [PK_TemplateParamsSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClientChanelsSet'
ALTER TABLE [dbo].[ClientChanelsSet]
ADD CONSTRAINT [PK_ClientChanelsSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClientStateSet'
ALTER TABLE [dbo].[ClientStateSet]
ADD CONSTRAINT [PK_ClientStateSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ChanelStateSet'
ALTER TABLE [dbo].[ChanelStateSet]
ADD CONSTRAINT [PK_ChanelStateSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'LanguagesSet'
ALTER TABLE [dbo].[LanguagesSet]
ADD CONSTRAINT [PK_LanguagesSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CurrenciesSet'
ALTER TABLE [dbo].[CurrenciesSet]
ADD CONSTRAINT [PK_CurrenciesSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ContactPeopleSet'
ALTER TABLE [dbo].[ContactPeopleSet]
ADD CONSTRAINT [PK_ContactPeopleSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PaymentsSet'
ALTER TABLE [dbo].[PaymentsSet]
ADD CONSTRAINT [PK_PaymentsSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BanksInfoSet'
ALTER TABLE [dbo].[BanksInfoSet]
ADD CONSTRAINT [PK_BanksInfoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PositionsSet'
ALTER TABLE [dbo].[PositionsSet]
ADD CONSTRAINT [PK_PositionsSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TemplateParamsTypeSet'
ALTER TABLE [dbo].[TemplateParamsTypeSet]
ADD CONSTRAINT [PK_TemplateParamsTypeSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FilesSet'
ALTER TABLE [dbo].[FilesSet]
ADD CONSTRAINT [PK_FilesSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FIleErrorSet'
ALTER TABLE [dbo].[FIleErrorSet]
ADD CONSTRAINT [PK_FIleErrorSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Clients_Id] in table 'ClientStateSet'
ALTER TABLE [dbo].[ClientStateSet]
ADD CONSTRAINT [FK_ClientsClientState]
    FOREIGN KEY ([Clients_Id])
    REFERENCES [dbo].[ClientsSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientsClientState'
CREATE INDEX [IX_FK_ClientsClientState]
ON [dbo].[ClientStateSet]
    ([Clients_Id]);
GO

-- Creating foreign key on [ChanelState_Id] in table 'ChanelsSet'
ALTER TABLE [dbo].[ChanelsSet]
ADD CONSTRAINT [FK_ChanelStateChanels]
    FOREIGN KEY ([ChanelState_Id])
    REFERENCES [dbo].[ChanelStateSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ChanelStateChanels'
CREATE INDEX [IX_FK_ChanelStateChanels]
ON [dbo].[ChanelsSet]
    ([ChanelState_Id]);
GO

-- Creating foreign key on [Chanels_Id] in table 'ClientChanelsSet'
ALTER TABLE [dbo].[ClientChanelsSet]
ADD CONSTRAINT [FK_ClientChanelsChanels]
    FOREIGN KEY ([Chanels_Id])
    REFERENCES [dbo].[ChanelsSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientChanelsChanels'
CREATE INDEX [IX_FK_ClientChanelsChanels]
ON [dbo].[ClientChanelsSet]
    ([Chanels_Id]);
GO

-- Creating foreign key on [Clients_Id] in table 'ClientChanelsSet'
ALTER TABLE [dbo].[ClientChanelsSet]
ADD CONSTRAINT [FK_ClientChanelsClients]
    FOREIGN KEY ([Clients_Id])
    REFERENCES [dbo].[ClientsSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientChanelsClients'
CREATE INDEX [IX_FK_ClientChanelsClients]
ON [dbo].[ClientChanelsSet]
    ([Clients_Id]);
GO

-- Creating foreign key on [Clients_Id] in table 'PaymentsSet'
ALTER TABLE [dbo].[PaymentsSet]
ADD CONSTRAINT [FK_ClientsPayments]
    FOREIGN KEY ([Clients_Id])
    REFERENCES [dbo].[ClientsSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientsPayments'
CREATE INDEX [IX_FK_ClientsPayments]
ON [dbo].[PaymentsSet]
    ([Clients_Id]);
GO

-- Creating foreign key on [Executors_Id] in table 'ClientsSet'
ALTER TABLE [dbo].[ClientsSet]
ADD CONSTRAINT [FK_ClientsExecutors]
    FOREIGN KEY ([Executors_Id])
    REFERENCES [dbo].[ExecutorsSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientsExecutors'
CREATE INDEX [IX_FK_ClientsExecutors]
ON [dbo].[ClientsSet]
    ([Executors_Id]);
GO

-- Creating foreign key on [Clients_Id] in table 'ContactPeopleSet'
ALTER TABLE [dbo].[ContactPeopleSet]
ADD CONSTRAINT [FK_ClientsContactPeople]
    FOREIGN KEY ([Clients_Id])
    REFERENCES [dbo].[ClientsSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientsContactPeople'
CREATE INDEX [IX_FK_ClientsContactPeople]
ON [dbo].[ContactPeopleSet]
    ([Clients_Id]);
GO

-- Creating foreign key on [ContactPeople_Id] in table 'PositionsSet'
ALTER TABLE [dbo].[PositionsSet]
ADD CONSTRAINT [FK_PositionsContactPeople]
    FOREIGN KEY ([ContactPeople_Id])
    REFERENCES [dbo].[ContactPeopleSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PositionsContactPeople'
CREATE INDEX [IX_FK_PositionsContactPeople]
ON [dbo].[PositionsSet]
    ([ContactPeople_Id]);
GO

-- Creating foreign key on [Clients_Id] in table 'BanksInfoSet'
ALTER TABLE [dbo].[BanksInfoSet]
ADD CONSTRAINT [FK_BanksInfoClients]
    FOREIGN KEY ([Clients_Id])
    REFERENCES [dbo].[ClientsSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_BanksInfoClients'
CREATE INDEX [IX_FK_BanksInfoClients]
ON [dbo].[BanksInfoSet]
    ([Clients_Id]);
GO

-- Creating foreign key on [Languages_Id] in table 'ClientsSet'
ALTER TABLE [dbo].[ClientsSet]
ADD CONSTRAINT [FK_ClientsLanguages]
    FOREIGN KEY ([Languages_Id])
    REFERENCES [dbo].[LanguagesSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientsLanguages'
CREATE INDEX [IX_FK_ClientsLanguages]
ON [dbo].[ClientsSet]
    ([Languages_Id]);
GO

-- Creating foreign key on [Languages_Id] in table 'ChanelsSet'
ALTER TABLE [dbo].[ChanelsSet]
ADD CONSTRAINT [FK_ChanelsLanguages]
    FOREIGN KEY ([Languages_Id])
    REFERENCES [dbo].[LanguagesSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ChanelsLanguages'
CREATE INDEX [IX_FK_ChanelsLanguages]
ON [dbo].[ChanelsSet]
    ([Languages_Id]);
GO

-- Creating foreign key on [Currencies_Id] in table 'ClientsSet'
ALTER TABLE [dbo].[ClientsSet]
ADD CONSTRAINT [FK_CurrenciesClients]
    FOREIGN KEY ([Currencies_Id])
    REFERENCES [dbo].[CurrenciesSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CurrenciesClients'
CREATE INDEX [IX_FK_CurrenciesClients]
ON [dbo].[ClientsSet]
    ([Currencies_Id]);
GO

-- Creating foreign key on [Currencies_Id] in table 'PaymentsSet'
ALTER TABLE [dbo].[PaymentsSet]
ADD CONSTRAINT [FK_CurrenciesPayments]
    FOREIGN KEY ([Currencies_Id])
    REFERENCES [dbo].[CurrenciesSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CurrenciesPayments'
CREATE INDEX [IX_FK_CurrenciesPayments]
ON [dbo].[PaymentsSet]
    ([Currencies_Id]);
GO

-- Creating foreign key on [Templates_Id] in table 'TemplateParamsTypeSet'
ALTER TABLE [dbo].[TemplateParamsTypeSet]
ADD CONSTRAINT [FK_TemplateParamsTypeTemplates]
    FOREIGN KEY ([Templates_Id])
    REFERENCES [dbo].[TemplatesSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TemplateParamsTypeTemplates'
CREATE INDEX [IX_FK_TemplateParamsTypeTemplates]
ON [dbo].[TemplateParamsTypeSet]
    ([Templates_Id]);
GO

-- Creating foreign key on [TemplateParams_Id] in table 'TemplateParamsTypeSet'
ALTER TABLE [dbo].[TemplateParamsTypeSet]
ADD CONSTRAINT [FK_TemplateParamsTypeTemplateParams]
    FOREIGN KEY ([TemplateParams_Id])
    REFERENCES [dbo].[TemplateParamsSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TemplateParamsTypeTemplateParams'
CREATE INDEX [IX_FK_TemplateParamsTypeTemplateParams]
ON [dbo].[TemplateParamsTypeSet]
    ([TemplateParams_Id]);
GO

-- Creating foreign key on [Templates_Id] in table 'TemplateParamsSet'
ALTER TABLE [dbo].[TemplateParamsSet]
ADD CONSTRAINT [FK_TemplatesTemplateParams]
    FOREIGN KEY ([Templates_Id])
    REFERENCES [dbo].[TemplatesSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TemplatesTemplateParams'
CREATE INDEX [IX_FK_TemplatesTemplateParams]
ON [dbo].[TemplateParamsSet]
    ([Templates_Id]);
GO

-- Creating foreign key on [Clients_Id] in table 'TemplateParamsSet'
ALTER TABLE [dbo].[TemplateParamsSet]
ADD CONSTRAINT [FK_ClientsTemplateParams]
    FOREIGN KEY ([Clients_Id])
    REFERENCES [dbo].[ClientsSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientsTemplateParams'
CREATE INDEX [IX_FK_ClientsTemplateParams]
ON [dbo].[TemplateParamsSet]
    ([Clients_Id]);
GO

-- Creating foreign key on [Clients_Id] in table 'FilesSet'
ALTER TABLE [dbo].[FilesSet]
ADD CONSTRAINT [FK_ClientsFiles]
    FOREIGN KEY ([Clients_Id])
    REFERENCES [dbo].[ClientsSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientsFiles'
CREATE INDEX [IX_FK_ClientsFiles]
ON [dbo].[FilesSet]
    ([Clients_Id]);
GO

-- Creating foreign key on [Chanels_Id] in table 'FilesSet'
ALTER TABLE [dbo].[FilesSet]
ADD CONSTRAINT [FK_ChanelsFiles]
    FOREIGN KEY ([Chanels_Id])
    REFERENCES [dbo].[ChanelsSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ChanelsFiles'
CREATE INDEX [IX_FK_ChanelsFiles]
ON [dbo].[FilesSet]
    ([Chanels_Id]);
GO

-- Creating foreign key on [Files_Id] in table 'FIleErrorSet'
ALTER TABLE [dbo].[FIleErrorSet]
ADD CONSTRAINT [FK_FIleErrorFiles]
    FOREIGN KEY ([Files_Id])
    REFERENCES [dbo].[FilesSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FIleErrorFiles'
CREATE INDEX [IX_FK_FIleErrorFiles]
ON [dbo].[FIleErrorSet]
    ([Files_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------