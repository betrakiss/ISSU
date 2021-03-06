﻿module susiApp.Interfaces {
    'use strict';

    export interface IHomeService {
        getArticles(): ng.IPromise<Array<susiApp.Models.IArticleViewModel>>;
        getWebsites(): ng.IPromise<Array<susiApp.Models.IWebsite>>;
    }

    export interface INewsService {
        getFirstFew(): ng.IPromise<Array<susiApp.Models.IArticleViewModel>>;
        getArticle(id: number): ng.IPromise<susiApp.Models.IArticleViewModel>;
    }

    export interface ISUSIService {
        getStudentInfo(): ng.IPromise<susiApp.Models.IStudentViewModel>;
        getCourses(): ng.IPromise<Array<susiApp.Models.ICourseResultViewModel>>;
    }
} 