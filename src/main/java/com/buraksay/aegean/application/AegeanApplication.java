package com.buraksay.aegean.application;

import java.util.HashSet;
import java.util.Set;

import javax.ws.rs.core.Application;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import com.buraksay.aegean.context.AppContext;
import com.buraksay.aegean.controller.IAmAliveController;

public class AegeanApplication extends Application {
    private final Set<Object> singletons = new HashSet<Object>();
    private final Set<Class<?>> empty = new HashSet<Class<?>>();

    private IAmAliveController iAmAliveController = null;

    private static final Logger LOGGER = LoggerFactory.getLogger(AegeanApplication.class);

    public AegeanApplication() {
        iAmAliveController = AppContext.getApplicationContext().getBean(IAmAliveController.class);
        LOGGER.debug("Fetched iamalivecontroller from Spring context: " + iAmAliveController);
        // LOGGER.debug("Fetched iamalivecontroller from Spring autowiring: " + iAmAliveController);
        singletons.add(iAmAliveController);
    }

    @Override
    public Set<Class<?>> getClasses() {
        return empty;
    }

    @Override
    public Set<Object> getSingletons() {
        return singletons;
    }
}