package com.buraksay.aegean.context;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.context.ApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

public abstract class AppContext {

    private static ApplicationContext appContext = null;
    private static final Logger LOGGER = LoggerFactory.getLogger(AppContext.class);

    public static void setApplicationContext(final ApplicationContext applicationContext) {
        appContext = applicationContext;
    }

    public static ApplicationContext getApplicationContext() {

        if (appContext == null) {
            appContext = new ClassPathXmlApplicationContext("context.xml");
        }

        return appContext;
    }

}
